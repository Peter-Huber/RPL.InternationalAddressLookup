using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using Newtonsoft.Json;
using RPL.InternationalAddress.Classes;
using RPL.InternationalAddress.Enums;

namespace RPL.InternationalAddress
{
    /// <summary>
    /// AFD Model
    /// </summary>
    public class AFDModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AFDModel"/> class.
        /// This will use the default 
        /// </summary>
        public AFDModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AFDModel"/> class.
        /// </summary>
        /// <param name="lookup">The lookup.</param>
        /// <param name="country">The country.</param>
        public AFDModel(string lookup, CountryCodes country)
        {
            this.Lookup = lookup;
            this.CountryISO = country;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AFDModel" /> class.
        /// </summary>
        /// <param name="serial">The serial.</param>
        /// <param name="password">The password.</param>
        /// <param name="lookup">The lookup.</param>
        /// <param name="country">The country.</param>
        public AFDModel(string serial, string password, string lookup, CountryCodes country)
        {
            this.Serial = serial;
            this.Password = password;
            this.Lookup = lookup;
            this.CountryISO = country;
        }

        /// <summary>
        /// Gets or sets the API URL.
        /// </summary>
        /// <value>
        /// The API URL.
        /// </value>
        public string APIUrl { get; set; } = "http://pce.afd.co.uk/afddata.pce";

        /// <summary>
        /// Gets or sets the user identifier of the Application e.g. MyApp.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets the API URL full.
        /// </summary>
        /// <value>
        /// The API URL full.
        /// </value>
        public string APIUrlFull
        {
            get
            {
                var request = $"{this.APIUrl}?Serial={this.Serial}&Password={this.Password}";
                if (!string.IsNullOrWhiteSpace(this.UserId))
                {
                    request += "&UserID=" + this.UserId;
                }

                request +=$"&Data={this.Data}&Task={this.Task}&Fields={this.Fields}&Lookup={this.Lookup}&CountryISO={this.CountryISO}";
                if (!string.IsNullOrWhiteSpace(this.Callback))
                {
                    request += "&callback=" + this.Callback;
                }

                return request;
            }
        }

        /// <summary>
        /// Gets or sets the callback. Set to empty for xml
        /// </summary>
        /// <value>
        /// The callback.
        /// </value>
        public string Callback { get; set; } = "json";

        /// <summary>
        /// Gets or sets the country ISO.
        /// </summary>
        /// <value>
        /// The country ISO.
        /// </value>
        public CountryCodes CountryISO { get; set; } = CountryCodes.FRA;

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public DataParamter Data { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public string Fields { get; set; } = "standard";

        /// <summary>
        /// Gets or sets the lookup.
        /// </summary>
        /// <value>
        /// The lookup.
        /// </value>
        public string Lookup { get; set; } = "Rue de Rivoli,75001";

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; } = "1wmrsW2n";

        /// <summary>
        /// Gets or sets the serial.
        /// </summary>
        /// <value>
        /// The serial.
        /// </value>
        public string Serial { get; set; } = "830152";

        /// <summary>
        /// Gets or sets the task.
        /// </summary>
        /// <value>
        /// The task.
        /// </value>
        public TaskAddressParameters Task { get; set; } = TaskAddressParameters.Lookup;

        /// <summary>
        /// Gets the json results.
        /// </summary>
        /// <returns></returns>
        public AFDPostcodeJson GetJsonResults()
        {
            this.CheckValidation();
            var lastCallback = this.Callback;
            this.Callback = "json";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(this.APIUrlFull);
            httpWebRequest.KeepAlive = false;
            httpWebRequest.Method = "GET";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.ContentType = "application/json";

            using (var response = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var reader = new StreamReader(response.GetResponseStream());
                    var xml = reader.ReadToEnd();

                    this.Callback = lastCallback;
                    xml = xml.Remove(0, "json(".Length);
                    xml = xml.Remove(xml.Length - 1);
                    return JsonConvert.DeserializeObject<AFDPostcodeJson>(xml);
                }
            }

            this.Callback = lastCallback;
            return new AFDPostcodeJson();
        }

        /// <summary>
        /// Gets the results as a string format depending if it is in XML or JSON format.
        /// </summary>
        /// <returns></returns>
        public string GetResults()
        {
            this.CheckValidation();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(this.APIUrlFull);
            httpWebRequest.KeepAlive = false;
            httpWebRequest.Method = "GET";

            if (this.Callback == "json")
            {
                httpWebRequest.Accept = "application/json";
                httpWebRequest.ContentType = "application/json";
            }

            using (var response = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var reader = new StreamReader(response.GetResponseStream());
                    var xml = reader.ReadToEnd();
                    return xml;
                }
            }

            return "";
        }

        /// <summary>
        /// Gets the XML results.
        /// </summary>
        /// <returns></returns>
        public AFDPostcodeEverywhere GetXmlResults()
        {
            this.CheckValidation();
            var lastCallback = this.Callback;
            this.Callback = "";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(this.APIUrlFull);
            httpWebRequest.KeepAlive = false;
            httpWebRequest.Method = "GET";

            using (var response = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var stream = new StreamReader(response.GetResponseStream());

                    var serializer = new XmlSerializer(typeof(AFDPostcodeEverywhere));
                    var results = (AFDPostcodeEverywhere)serializer.Deserialize(stream);
                    stream.Close();
                    return results;
                }
            }

            this.Callback = lastCallback;
            return new AFDPostcodeEverywhere();
        }

        private void CheckValidation()
        {
            if (string.IsNullOrEmpty(this.Serial))
            {
                throw new ArgumentException("A serial of null was inappropriately allowed.", nameof(this.Serial));
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                throw new ArgumentException("A password of null was inappropriately allowed.", nameof(this.Password));
            }

            if (string.IsNullOrEmpty(this.Lookup))
            {
                throw new ArgumentException("A lookup of null was inappropriately allowed.", nameof(this.Lookup));
            }
        }
    }
}