namespace TwoCheckout
{
    public class SaleRefundServiceOptions
    {
        public long? sale_id { get; set; }
        public long? invoice_id { get; set; }
        public long? lineitem_id { get; set; }
        public decimal? amount { get; set; }
        public string currency { get; set; }
        public string comment { get; set; }
        public int? category { get; set; }
    }
}
