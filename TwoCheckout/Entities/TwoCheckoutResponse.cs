namespace TwoCheckout
{
    public class TwoCheckoutResponse
    {
        public string response_code { get; set; }
        public string response_message { get; set; }
        public long? product_id { get; set; }
        public string coupon_code { get; set; }
        public long? option_id { get; set; }
    }
}
