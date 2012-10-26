using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TwoCheckout;

namespace UnitTests
{
    class TestContact
    {
        // Contact

        // Set API Credentials
        [Test]
        public void _001_SetUser()
        {
            TwocheckoutConfig.ApiUsername = "APIuser1817037";
            TwocheckoutConfig.ApiPassword = "APIpass1817037";
        }

        // Contact
        [Test]
        public void _002_TestContact()
        {
            var result = TwocheckoutContact.Retrieve();
            Assert.IsInstanceOf<Contact>(result);
        }
    }
}
