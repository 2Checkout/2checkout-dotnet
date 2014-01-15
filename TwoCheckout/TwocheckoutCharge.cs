using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TwoCheckout
{
    public class TwocheckoutCharge
    {
        public static String Form(Dictionary<string, string> args, String button)
        {
            StringBuilder Form = new StringBuilder();
            Form.Append("<form id=\"2checkout\" action=\"https://www.2checkout.com/checkout/purchase\" method=\"post\">\n");
            foreach (var parameter in args)
            {
                Form.Append("<input type=\"hidden\" name=\""+parameter.Key+"\" value=\""+parameter.Value+"\" />\n");
            }
            Form.Append("<input type=\"submit\" value=\"" + button + "\" />\n</form>\n");
            return Form.ToString();
        }

        public static String Submit(Dictionary<string, string> args, String button)
        {
            StringBuilder Form = new StringBuilder();
            Form.Append("<form id=\"2checkout\" action=\"https://www.2checkout.com/checkout/purchase\" method=\"post\">\n");
            foreach (var parameter in args)
            {
                Form.Append("<input type=\"hidden\" name=\"" + parameter.Key + "\" value=\"" + parameter.Value + "\" />\n");
            }
            Form.Append("</form>\n");
            Form.Append("<script type=\"text/javascript\">document.getElementById('2checkout').submit();</script>\n");
            return Form.ToString();
        }

        public static String Link(Dictionary<string, string> args)
        {
            StringBuilder Link = new StringBuilder("https://www.2checkout.com/checkout/purchase?");
            String Parameters = TwocheckoutUtil.ConstructQueryString(args);
            Link.Append(Parameters);
            return Link.ToString();
        }

        public static Authorization Authorize(Dictionary<string, object> args)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "checkout/api/1/" + args["sellerId"] + "/rs/authService";
            String ResultString = Request.ApiJson(UrlSuffix, args);
            JObject ResultObject = JObject.Parse(ResultString);
            ResultString = Newtonsoft.Json.JsonConvert.SerializeObject(ResultObject["response"]);
            Authorization ResponseObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Authorization>(ResultString);
            return ResponseObj;
        }
    }
}
