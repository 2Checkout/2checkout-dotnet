using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class Coupon
    {
        public string coupon_code { get; set; }
        public DateTime date_expire { get; set; }
        public decimal? minimum_purchase { get; set; }
        public decimal? percentage_off { get; set; }
        public string type { get; set; }
        public decimal? value_off { get; set; }
    }
}
