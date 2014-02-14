using System;
using System.Collections.Generic;
using System.Text;

namespace TwoCheckout
{
    public class ReturnService
    {
        public Boolean Check(ReturnCheckServiceOptions options)
        {
            Boolean Result;
            var HashString = new StringBuilder();
            HashString.Append(TwoCheckoutConfig.SecretWord);
            HashString.Append(TwoCheckoutConfig.SellerID);
            if (TwoCheckoutConfig.Demo)
            {
                HashString.Append("1");
            }
            else
            {
                HashString.Append(options.order_number);
            }
            HashString.Append(options.total);
            String CheckHash = TwoCheckoutUtil.Md5Hash(HashString.ToString());
            if (CheckHash != options.key)
            {
                Result = false;
            }
            else
            {
                Result = true;
            }
            return Result;
        }
    }
}
