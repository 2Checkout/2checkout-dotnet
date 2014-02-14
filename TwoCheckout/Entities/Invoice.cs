using System;

namespace TwoCheckout
{
    public class Invoice
    {
        public long? invoice_id { get; set; }
        public decimal? customer_total { get; set; }
        public DateTime? date_placed { get; set; }
        public DateTime? date_shipped { get; set; }
        public DateTime? date_vendor_paid { get; set; }
        public decimal? fees_2co { get; set; }
        public int? recurring { get; set; }
        public string referrer { get; set; }
        public long? sale_id { get; set; }
        public string status { get; set; }
        public decimal? usd_total { get; set; }
        public long? vendor_id { get; set; }
        public string vendor_order_id { get; set; }
        public decimal? vendor_total { get; set; }
        public Lineitems[] lineitems { get; set; }
        public Shipping shipping { get; set; }
    }
}