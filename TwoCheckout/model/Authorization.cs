using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class Authorization
    {
        public string type { get; set; }
        public string responseCode { get; set; }
        public string responseMsg { get; set; }
        public decimal? total { get; set; }
        public string currencyCode { get; set; }
        public string merchantOrderId { get; set; }
        public long? orderNumber { get; set; }
        public long? transactionId { get; set; }
    }
}
