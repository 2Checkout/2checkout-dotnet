namespace TwoCheckout
{
    public class SaleCommentServiceOptions
    {
        public long? sale_id { get; set; }
        public string sale_comment { get; set; }
        public int? cc_vendor { get; set; }
        public int? cc_customer { get; set; }
    }
}
