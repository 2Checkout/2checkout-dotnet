using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TwoCheckout;

namespace TwoCheckout
{
    public class TwocheckoutSale
    {
        public Sale sale { get; set; }

        public static Sale Retrieve(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi {};
            String UrlSuffix = "sales/detail_sale";
            String Result = Request.ApiGet(UrlSuffix, parameters);
            TwocheckoutSale saleObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutSale>(Result);
            return saleObj.sale;
        }

        public static SaleList List(Dictionary<string, string> parameters = null)
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "sales/list_sales";
            String Result = Request.ApiGet(UrlSuffix, parameters);
            SaleList saleObj = Newtonsoft.Json.JsonConvert.DeserializeObject<SaleList>(Result);
            return saleObj;
        }

        public static TwocheckoutResponse Stop(Dictionary<string, string> parameters)
        {
            String Result = null;
            TwocheckoutResponse activeObj = new TwocheckoutResponse();
            if (parameters.ContainsKey("sale_id"))
            {
                String UrlSuffix = "sales/detail_sale";
                var Request = new TwocheckoutApi {};
                Result = Request.ApiGet(UrlSuffix, parameters);
                Dictionary<string, string> Active = TwocheckoutUtil.Active(Result);
                if (Active.ContainsKey("lineitem_id0"))
                {
                    UrlSuffix = "sales/stop_lineitem_recurring";
                    var Response = new Dictionary<string, string>();
                    String stoppedLineitems = null;
                    foreach (var entry in Active)
                    {
                        var Params = new Dictionary<string, string>();
                        Params.Add("lineitem_id", entry.Value);
                        Result = Request.ApiPost(UrlSuffix, Params);
                        stoppedLineitems += "," + entry.Value;
                    }
                    stoppedLineitems = stoppedLineitems.Remove(0, 1);
                    Response.Add("response_code", "OK");
                    Response.Add("response_message", stoppedLineitems);
                    String Json = JsonConvert.SerializeObject(Response, Formatting.Indented);
                    activeObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Json);
                    return activeObj;
                }
                else
                {
                    TwocheckoutResponse Error = new TwocheckoutResponse();
                    Error.response_code = "Notice";
                    Error.response_message = "No active recurring lineitems.";
                    return Error;
                }
            } 
            else 
            {
                String UrlSuffix = "sales/stop_lineitem_recurring";
                var Request = new TwocheckoutApi {};
                Result = Request.ApiPost(UrlSuffix, parameters);
                activeObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            }
            return activeObj;
        }

        public static TwocheckoutResponse Refund(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi {};
            String Result;
            TwocheckoutResponse refundObj = new TwocheckoutResponse();
            if (parameters.ContainsKey("sale_id") || parameters.ContainsKey("invoice_id"))
            {
                String UrlSuffix = "sales/refund_invoice";
                Result = Request.ApiPost(UrlSuffix, parameters);
                refundObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            }
            else if (parameters.ContainsKey("lineitem_id"))
            {
                String UrlSuffix = "sales/refund_lineitem";
                Result = Request.ApiPost(UrlSuffix, parameters);
                refundObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            }
            else
            {
                refundObj.response_code = "Notice";
                refundObj.response_message = "You must pass a sale_id, invoice_id or lineitem_id.";
            }
            return refundObj;
        }

        public static TwocheckoutResponse Comment(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi {};
            String UrlSuffix = "sales/create_comment";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse commentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return commentObj;
        }

        public static TwocheckoutResponse Ship(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi {};
            String UrlSuffix = "sales/mark_shipped";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse shipObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return shipObj;
        }

        public static TwocheckoutResponse Reauth(Dictionary<string, string> parameters)
        {
            var Request = new TwocheckoutApi {};
            String UrlSuffix = "sales/reauth";
            String Result = Request.ApiPost(UrlSuffix, parameters);
            TwocheckoutResponse reauthObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutResponse>(Result);
            return reauthObj;
        }
    }
}
