using System;

namespace TwoCheckout
{
    public class Comments
    {
        public string changed_by_ip { get; set; }
        public string comment { get; set; }
        public DateTime? timestamp { get; set; }
        public string username { get; set; }
    }
}