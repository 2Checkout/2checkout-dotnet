namespace TwoCheckout
{
    public class SaleShipServiceOptions
    {
        public long? sale_id { get; set; }
        public long? invoice_id { get; set; }
        public string tracking_number { get; set; }
        public int? cc_customer { get; set; }
        public int? reauthorize { get; set; }
        public string comment { get; set; }
    }
}
