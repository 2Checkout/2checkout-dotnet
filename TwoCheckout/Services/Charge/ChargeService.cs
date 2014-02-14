using System;
using System.Collections.Generic;
using System.Text;

namespace TwoCheckout
{
    public class ChargeService
    {
        public static String Form(Dictionary<string, string> args, String button)
        {
            StringBuilder Form = new StringBuilder();
            Form.Append("<form id=\"2checkout\" action=\"https://www.2checkout.com/checkout/purchase\" method=\"post\">\n");
            foreach (var parameter in args)
            {
                Form.Append("<input type=\"hidden\" name=\"" + parameter.Key + "\" value=\"" + parameter.Value + "\" />\n");
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
            String Parameters = TwoCheckoutUtil.DictionaryToQueryString(args);
            Link.Append(Parameters);
            return Link.ToString();
        }

        public Authorization Authorize(ChargeAuthorizeServiceOptions options)
        {
            options.privateKey = TwoCheckoutConfig.PrivateKey;
            options.sellerId = TwoCheckoutConfig.SellerID;
            String Result = TwoCheckoutUtil.Request("checkout/api/1/" + TwoCheckoutConfig.SellerID + "/rs/authService", "POST", "payment", options);
            return TwoCheckoutUtil.MapToObject<Authorization>(Result, "response");
        }
    }
}