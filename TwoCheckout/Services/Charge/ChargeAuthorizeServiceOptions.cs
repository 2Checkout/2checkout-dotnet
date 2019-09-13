using System.Collections.Generic;

namespace TwoCheckout
{
    public class ChargeAuthorizeServiceOptions
    {
        public string sellerId { get; set; }
        public string privateKey { get; set; }
        public string merchantOrderId { get; set; }
        public string token { get; set; }
        public string currency { get; set; }
        public decimal? total { get; set; }
        public List<AuthLineitem> lineItems { get; set; }
        public AuthBillingAddress billingAddr { get; set; }
        public AuthShippingAddress shippingAddr { get; set; }
        public string returnUrl { get; set; }
        public bool demo { get; set; }
    }
}
