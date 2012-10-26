using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class Company
    {
        public string affiliate_url { get; set; }
        public string currency_code { get; set; }
        public string currency_name { get; set; }
        public string currency_symbol { get; set; }
        public string demo { get; set; }
        public string pending_return_url { get; set; }
        public int return_method { get; set; }
        public string return_url { get; set; }
        public string secret_word { get; set; }
        public string site_category { get; set; }
        public string site_description { get; set; }
        public string site_title { get; set; }
        public string soft_descriptor { get; set; }
        public string url { get; set; }
        public int vendor_id { get; set; }
        public string vendor_name { get; set; }
    }
}
