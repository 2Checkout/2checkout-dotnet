using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TwoCheckout;

namespace UnitTests
{
    public class TestCoupon
    {
        // Coupon
        public String coupon_code { get; set; }
        public String time = DateTime.Now.ToString("ss");

        // Set API Credentials
        [Test]
        public void _001_SetUser()
        {
            TwocheckoutConfig.ApiUsername = "APIuser1817037";
            TwocheckoutConfig.ApiPassword = "APIpass1817037";
        }

        // Create Coupon
        [Test]
        public void _002_TestCouponCreate()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("coupon_code", time);
            dictionary.Add("date_expire", "2099-12-22");
            dictionary.Add("type", "shipping");
            var result = TwocheckoutCoupon.Create(dictionary);
            coupon_code = result.coupon_code;
            Assert.IsInstanceOf<TwocheckoutResponse>(result);
        }

        // Retrieve Coupon
        [Test]
        public void _003_TestCouponRetrieve()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("coupon_code", time);
            var result = TwocheckoutCoupon.Retrieve(dictionary);
            Assert.IsInstanceOf<Coupon>(result);
        }

        // List Coupons
        [Test]
        public void _004_TestCouponList()
        {
            var result = TwocheckoutCoupon.List();
            Assert.IsInstanceOf<CouponList>(result);
        }

        // Update Coupon
        [Test]
        public void _005_TestCouponUpdate()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("coupon_code", time);
            dictionary.Add("date_expire", "2099-12-23");
            var result = TwocheckoutCoupon.Update(dictionary);
            Assert.IsInstanceOf<TwocheckoutResponse>(result);
        }

        // Delete Coupon
        [Test]
        public void _006_TestCouponDelete()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("coupon_code", coupon_code);
            var result = TwocheckoutCoupon.Delete(dictionary);
            Assert.IsInstanceOf<TwocheckoutResponse>(result);
        }
    }
}
