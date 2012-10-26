using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TwoCheckout;

namespace UnitTests
{
    public class TestOption
    {
        // Option
        public String option_id { get; set; }

        // Set API Credentials
        [Test]
        public void _001_SetUser()
        {
            TwocheckoutConfig.ApiUsername = "APIuser1817037";
            TwocheckoutConfig.ApiPassword = "APIpass1817037";
        }

        // Create Option
        [Test]
        public void _002_TestOptionCreate()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("name", "TestProduct");
            dictionary.Add("option_name", "TestOption");
            dictionary.Add("option_value_id", "Option1");
            dictionary.Add("option_value_name", "OptionValue");
            dictionary.Add("option_value_surcharge", "0.01");
            var result = TwocheckoutOption.Create(dictionary);
            option_id = result.option_id;
            Assert.IsInstanceOf<TwocheckoutResponse>(result);
        }

        // Retrieve Option
        [Test]
        public void _003_TestOptionRetrieve()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("option_id", option_id);
            var result = TwocheckoutOption.Retrieve(dictionary);
            Assert.IsInstanceOf<Option>(result);
        }

        // List Options
        [Test]
        public void _004_TestOptionList()
        {
            var result = TwocheckoutOption.List();
            Assert.IsInstanceOf<OptionList>(result);
        }

        // Update Option
        [Test]
        public void _005_TestOptionUpdate()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("option_id", option_id);
            dictionary.Add("option_name", "TestOption123");
            var result = TwocheckoutOption.Update(dictionary);
            Assert.IsInstanceOf<TwocheckoutResponse>(result);
        }

        // Delete Option
        [Test]
        public void _006_TestOptionDelete()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("option_id", option_id);
            var result = TwocheckoutOption.Delete(dictionary);
            Assert.IsInstanceOf<TwocheckoutResponse>(result);
        }
    }
}
