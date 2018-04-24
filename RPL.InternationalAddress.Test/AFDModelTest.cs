using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPL.InternationalAddress.Classes;
using RPL.InternationalAddress.Enums;

namespace RPL.InternationalAddress.Test
{
    [TestClass]
    public class AFDModelTest
    {
        [TestMethod]
        public void TestDefaultUrlInXml()
        {
            var model = new AFDModel
            {
                Callback = "",
                Task = TaskAddressParameters.FastFind
            };
            var url = model.APIUrlFull;
            const string expectedUrl = "http://pce.afd.co.uk/afddata.pce?Serial=830152&Password=1wmrsW2n&Data=Address&Task=FastFind&Fields=standard&Lookup=Rue de Rivoli,75001&CountryISO=FRA";

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestDefaultUrlInJson()
        {
            var model = new AFDModel
            {
                Task = TaskAddressParameters.FastFind
            };
            var url = model.APIUrlFull;
            const string expectedUrl = "http://pce.afd.co.uk/afddata.pce?Serial=830152&Password=1wmrsW2n&Data=Address&Task=FastFind&Fields=standard&Lookup=Rue de Rivoli,75001&CountryISO=FRA&callback=json";

            Assert.AreEqual(expectedUrl, url);
        }

        [TestMethod]
        public void TestJsonCallback()
        {
            var model = new AFDModel();
            AFDPostcodeJson result = model.GetJsonResults();

            Assert.AreEqual(100, result.Item.Length);
        }

        [TestMethod]
        public void TestXmlCallback()
        {
            var model = new AFDModel();
            AFDPostcodeEverywhere result = model.GetXmlResults();

            Assert.AreEqual(100, result.Item.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "A serial of null was inappropriately allowed.")]
        public void TestSerialValiadtion()
        {
            var nm = new AFDModel();
            var model = new AFDModel("", "1wmrsW2n", "Rue de Rivoli,75001", CountryCodes.FRA);
            model.GetJsonResults();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "A password of null was inappropriately allowed.")]
        public void TestPasswordValiadtion()
        {
            var nm = new AFDModel();
            var model = new AFDModel("830152", "", "Rue de Rivoli,75001", CountryCodes.FRA);
            model.GetJsonResults();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "A lookup of null was inappropriately allowed.")]
        public void TestLookupValiadtion()
        {
            var nm = new AFDModel();
            var model = new AFDModel("830152", "1wmrsW2n", "", CountryCodes.FRA);
            model.GetJsonResults();
        }

        [TestMethod]
        public void TestValiadtion()
        {
            var nm = new AFDModel();
            var model = new AFDModel("8301522", "1wmrsW2n", "Rue de Rivoli,75001", CountryCodes.FRA);
            AFDPostcodeJson results = model.GetJsonResults();
            Assert.AreEqual(0, results.Result);
            Assert.AreEqual(null, results.ErrorText);
            Assert.AreEqual(null, results.Item);
        }
    }
}
