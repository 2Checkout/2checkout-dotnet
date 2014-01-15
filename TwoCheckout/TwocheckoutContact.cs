using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class TwocheckoutContact
    {
        public Contact vendor_contact_info { get; set; }

        public static Contact Retrieve()
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "api/acct/detail_contact_info";
            String Result = Request.ApiGet(UrlSuffix);
            TwocheckoutContact contactObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutContact>(Result);
            return contactObj.vendor_contact_info;
        }
    }
}