using System;

namespace TwoCheckout
{
    public class Billing
    {
        public decimal? amount { get; set; }
        public string bill_method { get; set; }
        public long? billing_id { get; set; }
        public decimal? customer_amount { get; set; }
        public long? customer_id { get; set; }
        public DateTime? date_deposited { get; set; }
        public DateTime? date_end { get; set; }
        public DateTime? date_fail { get; set; }
        public DateTime? date_next { get; set; }
        public DateTime? date_pending { get; set; }
        public DateTime? date_start { get; set; }
        public long? lineitem_id { get; set; }
        public string recurring_status { get; set; }
        public string status { get; set; }
        public decimal? usd_amount { get; set; }
        public decimal? vendor_amount { get; set; }
    }
}