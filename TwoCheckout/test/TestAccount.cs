using System;
using System.Collections.Generic;
using NUnit.Framework;
using TwoCheckout;

namespace UnitTests
{
    public class TestAccount
    {
        // Set API Credentials
        [Test]
        public void _001_SetUser()
        {
            TwoCheckoutConfig.ApiUsername = "APIuser1817037";
            TwoCheckoutConfig.ApiPassword = "APIpass1817037";
        }

        // Create Coupon
        [Test]
        public void _002_TestAccountContactInfo()
        {
            var ServiceObject = new AccountService();
            var result = ServiceObject.ContactInfo();
            Assert.IsInstanceOf<Contact>(result);
        }

        // Create Coupon
        [Test]
        public void _002_TestAccountCompanyInfo()
        {
            var ServiceObject = new AccountService();
            var result = ServiceObject.CompanyInfo();
            Assert.IsInstanceOf<Company>(result);
        }

        // Create Coupon
        [Test]
        public void _002_TestAccountPendingPayment()
        {
            var ServiceObject = new AccountService();
            var result = ServiceObject.PendingPayment();
            Assert.IsInstanceOf<Payment>(result);
        }

        // Create Coupon
        [Test]
        public void _002_TestAccountListPayments()
        {
            var ServiceObject = new AccountService();
            var result = ServiceObject.ListPayments();
            Assert.IsInstanceOf<Payment>(result[0]);
        }


    }
}
