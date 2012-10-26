using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace TwoCheckout
{
    public class TwocheckoutReturn
    {

        public static TwocheckoutResponse Check(Dictionary<string, string> args, String secret)
        {
            TwocheckoutResponse Result = new TwocheckoutResponse();
            String Notice = JsonConvert.SerializeObject(Result, Formatting.Indented);
            if (!String.IsNullOrEmpty(secret) && args.ContainsKey("sid") &&
                args.ContainsKey("order_number") && args.ContainsKey("total")
                && args.ContainsKey("key"))
            {
                String HashString = secret + args["sid"] + args["order_number"] + args["total"];
                String CheckHash = TwocheckoutUtil.Md5Hash(HashString);
                if (CheckHash != args["key"])
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
                Result.response_message = "You must pass a sid, order_number, total, key and secret word.";
            }
            return Result;
        }
    }
}
