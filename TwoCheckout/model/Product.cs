using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class Product
    {
        public string approved_url { get; set; }
        public int assigned_product_id { get; set; }
        public Categories[] categories { get; set; }
        public string commission { get; set; }
        public string commission_type { get; set; }
        public string description { get; set; }
        public string duration { get; set; }
        public decimal? handling { get; set; }
        public Images[] images { get; set; }
        public string long_description { get; set; }
        public string name { get; set; }
        public Option[] options { get; set; }
        public string pending_url { get; set; }
        public decimal? price { get; set; }
        public long product_id { get; set; }
        public string recurrence { get; set; }
        public string startup_fee { get; set; }
        public string tangible { get; set; }
        public long vendor_id { get; set; }
        public string vendor_product_id { get; set; }
        public string weight { get; set; }
    }
}
