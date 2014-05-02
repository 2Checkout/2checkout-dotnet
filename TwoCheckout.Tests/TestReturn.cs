using System;
using System.Collections.Generic;
using NUnit.Framework;
using TwoCheckout;

namespace Twocheckout.Tests
{
    public class TestReturn
    {
        // Set Credentials
        [Test]
        public void _002_SetKey()
        {
            TwoCheckoutConfig.SecretWord = "tango";
            TwoCheckoutConfig.SellerID = "1817037";
        }

        // API Authorization
        [Test]
        public void _001_TestReturnCheck()
        {
            var Return = new ReturnService();
            var Args = new ReturnCheckServiceOptions();
            Args.total = "0.01";
            Args.order_number = "4774380224";
            Args.key = "7AB926D469648F3305AE361D5BD2C3CB";
            var result = Return.Check(Args);
            Assert.IsTrue(result);
        }
    }
}
