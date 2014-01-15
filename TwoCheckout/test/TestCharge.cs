using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TwoCheckout;

namespace UnitTests
{
    public class TestCharge
    {
        // Sales
        String token = "MmQ3NWY4MmQtOGQ0YS00NDdmLWI4OTAtZTVjYjI4MzZhNjZh";

        // Set API Key
        [Test]
        public void _002_SetKey()
        {
            TwocheckoutKey.PrivateKey = "9999999";
        }

        // API Authorization
        [Test]
        public void _001_TestApiAuthorization()
        {
            try
            {
                var billing = new Dictionary<string, string>();
                billing.Add("name", "Testing Tester");
                billing.Add("addrLine1", "123 test st");
                billing.Add("city", "Columbus");
                billing.Add("state", "OH");
                billing.Add("zipCode", "43123");
                billing.Add("country", "USA");
                billing.Add("email", "testingtester@2co.com");
                billing.Add("phoneNumber", "555-555-5555");

                var dictionary = new Dictionary<string, object>();
                dictionary.Add("sellerId", "1817037");
                dictionary.Add("merchantOrderId", "123");
                dictionary.Add("token", token);
                dictionary.Add("currency", "USD");
                dictionary.Add("total", "1.00");
                dictionary.Add("billingAddr", billing);

                var result = TwocheckoutCharge.Authorize(dictionary);
            }
            catch (TwocheckoutException e)
            {
                Assert.IsInstanceOf<TwocheckoutException>(e);
            }
        }
    }
}