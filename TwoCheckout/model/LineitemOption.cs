using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class LineitemOption
    {
        public long? lineitem_id { get; set; }
        public long? lineitem_option_id { get; set; }
        public string option_name { get; set; }
        public string option_value { get; set; }
        public decimal? usd_surcharge { get; set; }
        public decimal? vendor_surcharge { get; set; }
        public decimal? customer_surcharge { get; set; }
    }
}
