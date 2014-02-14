namespace TwoCheckout
{
    public class ProductCreateServiceOptions
    {
        public string name { get; set; }
        public decimal? price { get; set; }
        public string vendor_product_id { get; set; }
        public string description { get; set; }
        public string long_description { get; set; }
        public string pending_url { get; set; }
        public string approved_url { get; set; }
        public decimal? handling { get; set; }
        public int? tangible { get; set; }
        public decimal? weight { get; set; }
        public int? recurring { get; set; }
        public decimal? startup_fee { get; set; }
        public string recurrence { get; set; }
        public string duration { get; set; }
        public int? commission { get; set; }
        public string commission_type { get; set; }
        public decimal? commission_amount { get; set; }
        public long? option_id { get; set; }
        public long? category_id { get; set; }
    }
}