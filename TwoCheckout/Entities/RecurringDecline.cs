using System;

namespace TwoCheckout
{
    public class RecurringDecline
    {
        public DateTime? date_declined { get; set; }
        public DateTime? date_updated { get; set; }
        public string decline_code { get; set; }
        public string pay_method { get; set; }
        public string pplus_code { get; set; }
        public int retries { get; set; }
        public long? sale_id { get; set; }
    }
}
