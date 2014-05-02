using System;
using System.Collections.Generic;
using NUnit.Framework;
using TwoCheckout;

namespace Twocheckout.Tests
{
    public class TestCoupon
    {
        // Coupon
        public String coupon_code { get; set; }
        public String time = DateTime.Now.ToString("ddss") + DateTime.Now.ToString("ss");

        // Set API Credentials
        [Test]
        public void _001_SetUser()
        {
            TwoCheckoutConfig.ApiUsername = "APIuser1817037";
            TwoCheckoutConfig.ApiPassword = "APIpass1817037";
        }

        // Create Coupon
        [Test]
        public void _002_TestCouponCreate()
        {
            var ServiceObject = new CouponService();
            var ArgsObject = new CouponCreateServiceOptions();
            ArgsObject.coupon_code = time;
            ArgsObject.date_expire = "2099-12-22";
            ArgsObject.type = "shipping";
            var result = ServiceObject.Create(ArgsObject);
            coupon_code = result.coupon_code;
            Assert.IsInstanceOf<TwoCheckoutResponse>(result);
        }

        // Retrieve Coupon
        [Test]
        public void _003_TestCouponRetrieve()
        {
            var ServiceObject = new CouponService();
            var ArgsObject = new CouponRetrieveServiceOptions();
            ArgsObject.coupon_code = coupon_code;
            var result = ServiceObject.Retrieve(ArgsObject);
            Assert.IsInstanceOf<Coupon>(result);
        }

        // List Coupons
        [Test]
        public void _004_TestCouponList()
        {
            var ServiceObject = new CouponService();
            var result = ServiceObject.List();
            Assert.IsInstanceOf<CouponList>(result);
        }

        // Update Coupon
        [Test]
        public void _005_TestCouponUpdate()
        {
            var ServiceObject = new CouponService();
            var ArgsObject = new CouponUpdateServiceOptions();
            ArgsObject.coupon_code = coupon_code;
            ArgsObject.date_expire = "2099-12-22";
            var result = ServiceObject.Update(ArgsObject);
            coupon_code = result.coupon_code;
            Assert.IsInstanceOf<TwoCheckoutResponse>(result);
        }

        // Delete Coupon
        [Test]
        public void _006_TestCouponDelete()
        {
            var ServiceObject = new CouponService();
            var ArgsObject = new CouponDeleteServiceOptions();
            ArgsObject.coupon_code = coupon_code;
            var result = ServiceObject.Delete(ArgsObject);
            Assert.IsInstanceOf<TwoCheckoutResponse>(result);
        }
    }
}
