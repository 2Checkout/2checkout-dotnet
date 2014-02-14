using System;
using System.Collections.Generic;

namespace TwoCheckout
{
    public class CouponService
    {

        public Coupon Retrieve(CouponRetrieveServiceOptions options)
        {
            String Result = TwoCheckoutUtil.Request("api/products/detail_coupon", "GET", "admin", options);
            return TwoCheckoutUtil.MapToObject<Coupon>(Result, "coupon");
        }

        public TwoCheckoutResponse Create(CouponCreateServiceOptions options)
        {
            String Result = TwoCheckoutUtil.Request("api/products/create_coupon", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

        public CouponList List()
        {
            String Result = TwoCheckoutUtil.Request("api/products/list_coupons", "GET", "admin");
            return TwoCheckoutUtil.MapToObject<CouponList>(Result);
        }

        public TwoCheckoutResponse Update(CouponUpdateServiceOptions options = null)
        {
            String Result = TwoCheckoutUtil.Request("api/products/update_coupon", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

        public TwoCheckoutResponse Delete(CouponDeleteServiceOptions options = null)
        {
            String Result = TwoCheckoutUtil.Request("api/products/delete_coupon", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

    }
}