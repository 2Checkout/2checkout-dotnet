namespace TwoCheckout
{
    public class Shipping
    {
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string date_shipped { get; set; }
        public long? invoice_id { get; set; }
        public string postal_code { get; set; }
        public long? shipping_address_id { get; set; }
        public long? shipping_id { get; set; }
        public long? shipping_method_id { get; set; }
        public string shipping_method_name { get; set; }
        public string shipping_name { get; set; }
        public string state { get; set; }
        public string tracking_number { get; set; }
        public string tracking_url { get; set; }
    }
}
