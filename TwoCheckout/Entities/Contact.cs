namespace TwoCheckout
{
    public class Contact
    {
        public int? vendor_id { get; set; }
        public long? mailing_address_id { get; set; }
        public string mailing_address_1 { get; set; }
        public string mailing_address_2 { get; set; }
        public string mailing_city { get; set; }
        public string mailing_state { get; set; }
        public string mailing_postal_code { get; set; }
        public string mailing_country_code { get; set; }
        public long? physical_address_id { get; set; }
        public string physical_address_1 { get; set; }
        public string physical_address_2 { get; set; }
        public string physical_city { get; set; }
        public string physical_state { get; set; }
        public string physical_postal_code { get; set; }
        public string physical_country_code { get; set; }
        public string office_phone { get; set; }
        public string office_phone_ext { get; set; }
        public string office_email { get; set; }
        public string customer_service_phone { get; set; }
        public string customer_service_phone_ext { get; set; }
        public string customer_service_email { get; set; }
    }
}