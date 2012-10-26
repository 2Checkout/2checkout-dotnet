using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class TwocheckoutCompany
    {
        public Company vendor_company_info { get; set; }

        public static Company Retrieve()
        {
            var Request = new TwocheckoutApi { };
            String UrlSuffix = "acct/detail_company_info";
            String Result = Request.ApiGet(UrlSuffix);
            TwocheckoutCompany companyObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TwocheckoutCompany>(Result);
            return companyObj.vendor_company_info;
        }
    }
}