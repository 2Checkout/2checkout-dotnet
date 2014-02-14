namespace TwoCheckout
{
    public class Customer
    {
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string address_id { get; set; }
        public string cardholder_name { get; set; }
        public string city { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public long? customer_id { get; set; }
        public string email_address { get; set; }
        public string first_name { get; set; }
        public string lang { get; set; }
        public string last_name { get; set; }
        public string middle_initial { get; set; }
        public PayMethod pay_method { get; set; }
    }
}