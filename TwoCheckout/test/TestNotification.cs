using System;
using System.Collections.Generic;
using NUnit.Framework;
using TwoCheckout;

namespace UnitTests
{
    public class TestNotification
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
        public void _001_TestNotificationCheck()
        {
            var Notification = new NotificationService();
            var Args = new NotificationCheckServiceOptions();
            Args.invoice_id = "4632527490";
            Args.sale_id = "4632527448";
            Args.md5_hash = "4FB7CD1CD57BBEFCCA462F3DE823C50A";
            var result = Notification.Check(Args);
            Assert.IsTrue(result);
        }
    }
}
