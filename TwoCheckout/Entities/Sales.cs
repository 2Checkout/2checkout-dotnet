using System;
using System.Collections.Generic;

namespace TwoCheckout
{
    public class Sales
    {
        public long? sale_id { get; set; }
        public DateTime? date_placed { get; set; }
        public string customer_name { get; set; }
        public int? recurring { get; set; }
        public DateTime? recurring_declined { get; set; }
        public decimal? customer_total { get; set; }
        public string sale_url { get; set; }
    }
}
