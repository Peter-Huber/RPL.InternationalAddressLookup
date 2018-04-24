using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RPL.InternationalAddress.Enums;

namespace WebServerPostcodeLookup.Models
{
    public class HomeModel
    {
        public string PostcodeSearch { get; set; }
        public string CountrySearch { get; set; }
        public SelectList Countries { get; set; }
        public string Error { get; set; }
        public SelectList AddressList { get; set; }
        public string AddressSelected { get; set; }
        public string Organisation { get; set; }
        public string Property { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string List { get; set; }
        public string CurrentCountry { get; set; }
    }
}