using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;
using RPL.InternationalAddress;
using RPL.InternationalAddress.Classes;
using RPL.InternationalAddress.Enums;
using WebServerPostcodeLookup.Models;

namespace WebServerPostcodeLookup.Controllers
{
    public class HomeController : Controller
    {
        private static string lastSearch;

        public ActionResult Index()
        {
            var model = new HomeModel
            {
                Error = "International Address Lookup",
                Countries = this.GetCountries()
            };
            model.CurrentCountry = RegionInfo.CurrentRegion.DisplayName;
            var def = new AFDModel();
            model.CountrySearch = def.CountryISO.ToString();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(HomeModel model)
        {
            Enum.TryParse(model.CountrySearch, out CountryCodes code);
            var search = new AFDModel(model.PostcodeSearch, code)
            {
                Task = TaskAddressParameters.FastFind
            };

            var newSearch = model.PostcodeSearch + ", " + code;
            if (newSearch != lastSearch)
            {
                lastSearch = newSearch;
                model.AddressSelected = string.Empty;
                model.Organisation = string.Empty;
                model.Street = string.Empty;
                model.Property = string.Empty;
                model.Town = string.Empty;
                model.Locality = string.Empty;
                model.Postcode = string.Empty;
                model.List = string.Empty;
            }

            AFDPostcodeEverywhere result = search.GetXmlResults();

            // Check for error
            if (result.Result < 0)
            {
                model.Error = result.ErrorText;
            }
            else
            {
                model.Error = "International Address Lookup";
                model.AddressList = this.GetAddressList(result.Item);

                if (result.Item.Length == 1)
                {
                    model.AddressSelected = "1";
                }

                if (!string.IsNullOrWhiteSpace(model.AddressSelected))
                {
                    var index = int.Parse(model.AddressSelected) - 1;
                    AFDPostcodeEverywhereItem a = result.Item[index];
                    model.Organisation = a.Organisation;
                    model.Street = a.Street;
                    model.Property = a.Property;
                    model.Town = a.Town;
                    model.Locality = a.Locality;
                    model.Postcode = a.Postcode;
                    model.List = a.List;
                }
            }


            model.CurrentCountry = RegionInfo.CurrentRegion.DisplayName;
            model.Countries = this.GetCountries();
            return View(model);
        }

        private SelectList GetAddressList(AFDPostcodeEverywhereItem[] items)
        {
            var list = new List<SelectListItem>();
            foreach (AFDPostcodeEverywhereItem item in items)
            {
                list.Add(new SelectListItem()
                {
                    Text = item.List,
                    Value = item.value.ToString()
                });
            }

            return new SelectList(list, "Value", "Text");
        }

        private SelectList GetCountries()
        {
            var list = new List<SelectListItem>();
            foreach (KeyValuePair<CountryCodes, string> country in CountryCode.List)
            {
                list.Add(new SelectListItem()
                {
                    Text = country.Value,
                    Value = country.Key.ToString()
                });
            }

            return new SelectList(list, "Value", "Text");
        }
    }
}