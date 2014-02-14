namespace TwoCheckout
{
    public class OptionUpdateServiceOptions
    {
        public long? option_id { get; set; }
        public string option_name { get; set; }
        public long? option_value_id { get; set; }
        public string option_value_name { get; set; }
        public decimal? option_value_surcharge { get; set; }
    }
}
