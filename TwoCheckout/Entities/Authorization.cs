namespace TwoCheckout
{
    public class Authorization
    {
        public string responseMsg { get; set; }
        public string responseCode { get; set; }
        public string type { get; set; }
        public long? orderNumber { get; set; }
        public string merchantOrderId { get; set; }
        public long? transactionId { get; set; }
        public string currencyCode { get; set; }
        public decimal? total { get; set; }
        public AuthLineitem[] lineItems { get; set; }
        public AuthBillingAddress billingAddr { get; set; }
        public AuthShippingAddress shippingAddr { get; set; }
    }
}
