using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class TwocheckoutResponse
    {
        public string response_code { get; set; }
        public string response_message { get; set; }
        public string product_id { get; set; }
        public string assigned_product_id { get; set; }
        public string coupon_code { get; set; }
        public string option_id { get; set; }
    }
}
