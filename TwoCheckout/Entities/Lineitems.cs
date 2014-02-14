namespace TwoCheckout
{
    public class Lineitems
    {
        public decimal? commission { get; set; }
        public string commission_affiliate_vendor_id { get; set; }
        public string commission_flat_rate { get; set; }
        public string commission_percentage { get; set; }
        public string commission_type { get; set; }
        public decimal? commission_usd_amount { get; set; }
        public decimal? customer_amount { get; set; }
        public string flat_rate { get; set; }
        public long? installment { get; set; }
        public long? invoice_id { get; set; }
        public long? lc_affiliate_vendor_id { get; set; }
        public decimal? lc_usd_amount { get; set; }
        public long? lineitem_id { get; set; }
        public long? linked_id { get; set; }
        public ProductOptions[] options { get; set; }
        public Billing billing { get; set; }
        public string percentage { get; set; }
        public string product_description { get; set; }
        public string product_duration { get; set; }
        public string product_handling { get; set; }
        public long? product_id { get; set; }
        public string product_is_cart { get; set; }
        public string product_name { get; set; }
        public decimal? product_price { get; set; }
        public string product_recurrence { get; set; }
        public string product_startup_fee { get; set; }
        public string product_tangible { get; set; }
        public long? sale_id { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public decimal? usd_amount { get; set; }
        public decimal? usd_commission { get; set; }
        public decimal? vendor_amount { get; set; }
        public string vendor_product_id { get; set; }
    }
}
