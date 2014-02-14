using System.Collections.Generic;

namespace TwoCheckout
{
    public class AuthLineitem
    {
        public string type { get; set; }
        public string name { get; set; }
        public decimal? quantity { get; set; }
        public decimal? price { get; set; }
        public string tangible { get; set; }
        public string productId { get; set; }
        public string recurrence { get; set; }
        public string duration { get; set; }
        public decimal? startupFee { get; set; }
        public List<AuthLineitemOption> options { get; set; }
    }
}
