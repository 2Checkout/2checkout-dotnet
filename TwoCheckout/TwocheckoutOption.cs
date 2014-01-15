using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TwoCheckout;

namespace TwoCheckout
{
    public class TwocheckoutOption
    {
        public Option[] option { get; set; }

        public static Option Retrieve(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "api/products/detail_option";
            String Result = Request.ApiGet(UrlSuffix, parameters);
            TwocheckoutOption optObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutOption>(Result);
            return optObj.option[0];
        }

        public static OptionList List(Dictionary<string, string> parameters = null)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "api/products/list_options";
            String Result = Request.ApiGet(UrlSuffix, parameters);
            OptionList listObj = Newtonsoft.Json.JsonConvert.DeserializeObject<OptionList>(Result);
            return listObj;
        }

        public static TwocheckoutResponse Create(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "api/products/create_option";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse createObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return createObj;
        }

        public static TwocheckoutResponse Update(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "api/products/update_option";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse updateObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return updateObj;
        }

        public static TwocheckoutResponse Delete(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "api/products/delete_option";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse deleteObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return deleteObj;
        }
    }
}