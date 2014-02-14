namespace TwoCheckout
{
    public class CouponCreateServiceOptions
    {
        public string coupon_code { get; set; }
        public string date_expire { get; set; }
        public decimal? minimum_purchase { get; set; }
        public decimal? percentage_off { get; set; }
        public string type { get; set; }
        public decimal? value_off { get; set; }
        public long? product_id { get; set; }
        public int? select_all { get; set; }
    }
}