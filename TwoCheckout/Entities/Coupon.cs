namespace TwoCheckout
{
    public class Coupon
    {
        public string coupon_code { get; set; }
        public string date_expire { get; set; }
        public decimal? minimum_purchase { get; set; }
        public int? percentage_off { get; set; }
        public string type { get; set; }
        public decimal? value_off { get; set; }
    }
}
