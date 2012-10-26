using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace TwoCheckout
{
    public class TwocheckoutNotification
    {

        public static TwocheckoutResponse Check(Dictionary<string, string> args, String secret)
        {
            TwocheckoutResponse Result = new TwocheckoutResponse();
            String Notice = JsonConvert.SerializeObject(Result, Formatting.Indented);
            if (!String.IsNullOrEmpty(secret) && args.ContainsKey("sale_id") &&
                args.ContainsKey("vendor_id") && args.ContainsKey("invoice_id")
                && args.ContainsKey("md5_hash"))
            {
                String HashString = args["sale_id"] + args["vendor_id"] + args["invoice_id"] + secret;
                String CheckHash = TwocheckoutUtil.Md5Hash(HashString);
                if (CheckHash != args["md5_hash"])
                {
                    Result.response_code = "Fail";
                    Result.response_message = "Hash Mismatch";
                }
                else
                {
                    Result.response_code = "Success";
                    Result.response_message = "Hash Matched";
                }
            }
            else
            {
                Result.response_code = "Notice";
                Result.response_message = "You must pass a sale_id, vendor_id, invoice_id, md5_hash and secret word.";
            }
            return Result;
        }
    }
}