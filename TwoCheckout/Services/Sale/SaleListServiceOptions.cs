namespace TwoCheckout
{
    public class SaleListServiceOptions
    {
        public long? sale_id { get; set; }
        public long? invoice_id { get; set; }
        public string customer_name { get; set; }
        public string customer_email { get; set; }
        public string customer_phone { get; set; }
        public string vendor_product_id { get; set; }
        public int? ccard_first6 { get; set; }
        public int? ccard_last2 { get; set; }
        public string sale_date_begin { get; set; }
        public string sale_date_end { get; set; }
        public int? declined_recurrings { get; set; }
        public int? active_recurrings { get; set; }
        public int? refunded { get; set; }
        public int? cur_page { get; set; }
        public int? pagesize { get; set; }
        public string sort_col { get; set; }
        public string sort_dir { get; set; }
    }
}