namespace TwoCheckout
{
    public class Payment
    {
        public decimal? amount { get; set; }
        public decimal? reserve_held { get; set; }
        public decimal? reserve_released { get; set; }
        public decimal? total_sales { get; set; }
        public decimal? total_fees { get; set; }
        public decimal? total_refunds { get; set; }
        public decimal? total_chargeback_fees { get; set; }
        public decimal? total_adjustments { get; set; }
        public decimal? total_commissions { get; set; }
        public decimal? total_outgoing_commissions { get; set; }
        public decimal? total_balance_forward { get; set; }
        public decimal? payment_fee { get; set; }
        public long? payment_id { get; set; }
        public string payment_method { get; set; }
        public decimal? release_level { get; set; }
    }
}
