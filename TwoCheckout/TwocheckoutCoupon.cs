using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TwoCheckout
{
    public class TwocheckoutCoupon
    {
        public Coupon coupon { get; set; }

        public static Coupon Retrieve(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "products/detail_coupon";
            String Result = Request.ApiGet(UrlSuffix, parameters);
            TwocheckoutCoupon optObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutCoupon>(Result);
            return optObj.coupon;
        }

        public static CouponList List(Dictionary<string, string> parameters = null)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "products/list_coupons";
            String Result = Request.ApiGet(UrlSuffix, parameters);
            CouponList listObj = Newtonsoft.Json.JsonConvert.DeserializeObject<CouponList>(Result);
            return listObj;
        }

        public static TwocheckoutResponse Create(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "products/create_coupon";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse createObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return createObj;
        }

        public static TwocheckoutResponse Update(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "products/update_coupon";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse updateObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return updateObj;
        }

        public static TwocheckoutResponse Delete(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "products/delete_coupon";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse deleteObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return deleteObj;
        }
    }
}