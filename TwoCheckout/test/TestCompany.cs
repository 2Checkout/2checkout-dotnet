using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TwoCheckout;

namespace UnitTests
{
    public class TestCompany
    {
        // Company

        // Set API Credentials
        [Test]
        public void _001_SetUser()
        {
            TwocheckoutConfig.ApiUsername = "APIuser1817037";
            TwocheckoutConfig.ApiPassword = "APIpass1817037";
        }

        // Company
        [Test]
        public void _002_TestCompany()
        {
            var result = TwocheckoutCompany.Retrieve();
            Assert.IsInstanceOf<Company>(result);
        }
    }
}
