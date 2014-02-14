using System;
using System.Collections.Generic;
using NUnit.Framework;
using TwoCheckout;

namespace UnitTests
{
    public class TestOption
    {
        // Product
        public long? option_id { get; set; }

        // Set API Credentials
        [Test]
        public void _001_SetUser()
        {
            TwoCheckoutConfig.ApiUsername = "APIuser1817037";
            TwoCheckoutConfig.ApiPassword = "APIpass1817037";
        }

        // Create Option
        [Test]
        public void _002_TestOptionCreate()
        {
            var ServiceObject = new OptionService();
            var ArgsObject = new OptionCreateServiceOptions();
            ArgsObject.option_name = "Test Option";
            ArgsObject.option_value_name = "Test Opiton Value";
            ArgsObject.option_value_surcharge = (decimal)2.00;
            var result = ServiceObject.Create(ArgsObject);
            option_id = result.option_id;
            Assert.IsInstanceOf<TwoCheckoutResponse>(result);
        }

        // Retrieve Option
        [Test]
        public void _003_TestOptionRetrieve()
        {
            var ServiceObject = new OptionService();
            var ArgsObject = new OptionRetrieveServiceOptions();
            ArgsObject.option_id = option_id;
            var result = ServiceObject.Retrieve(ArgsObject);
            Assert.IsInstanceOf<Option>(result);
        }

        // List Options
        [Test]
        public void _004_TestOptionList()
        {
            var ServiceObject = new OptionService();
            var result = ServiceObject.List();
            Assert.IsInstanceOf<OptionList>(result);
        }

        // Update Option
        [Test]
        public void _005_TestOptionUpdate()
        {
            var ServiceObject = new OptionService();
            var ArgsObject = new OptionUpdateServiceOptions();
            ArgsObject.option_id = option_id;
            ArgsObject.option_name = "Test Option 123";
            ArgsObject.option_value_name = "Test Option Value 123";
            ArgsObject.option_value_surcharge = (decimal)1.00;
            var result = ServiceObject.Update(ArgsObject);
            Assert.IsInstanceOf<TwoCheckoutResponse>(result);
        }

        // Delete Option
        [Test]
        public void _006_TestOptionDelete()
        {
            var ServiceObject = new OptionService();
            var ArgsObject = new OptionDeleteServiceOptions();
            ArgsObject.option_id = option_id;
            var result = ServiceObject.Delete(ArgsObject);
            Assert.IsInstanceOf<TwoCheckoutResponse>(result);
        }
    }
}
