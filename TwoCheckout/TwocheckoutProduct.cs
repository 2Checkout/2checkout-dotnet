using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TwoCheckout;

namespace TwoCheckout
{
    public class TwocheckoutProduct
    {
        public Product product { get; set; }

        public static Product Retrieve(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "products/detail_product";
            String Result = Request.ApiGet(UrlSuffix, parameters);
            TwocheckoutProduct prodObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutProduct>(Result);
            return prodObj.product;
        }

        public static TwocheckoutResponse Create(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "products/create_product";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse createObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return createObj;
        }

        public static ProductList List(Dictionary<string, string> parameters = null)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "products/list_products";
            String Result = Request.ApiGet(UrlSuffix, parameters);
            ProductList listObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductList>(Result);
            return listObj;
        }

        public static TwocheckoutResponse Update(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "products/update_product";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse updateObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return updateObj;
        }

        public static TwocheckoutResponse Delete(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "products/delete_product";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse deleteObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return deleteObj;
        }
    }
}