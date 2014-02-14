using System;
using System.Collections.Generic;
using System.Text;

namespace TwoCheckout
{
    public class NotificationService
    {
        public Boolean Check(NotificationCheckServiceOptions options)
        {
            Boolean Result;
            var HashString = new StringBuilder();
            HashString.Append(options.sale_id);
            HashString.Append(TwoCheckoutConfig.SellerID);
            HashString.Append(options.invoice_id);
            HashString.Append(TwoCheckoutConfig.SecretWord);
            String CheckHash = TwoCheckoutUtil.Md5Hash(HashString.ToString());
            if (CheckHash != options.md5_hash)
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
