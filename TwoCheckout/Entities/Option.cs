namespace TwoCheckout
{
    public class Option
    {
        public long? option_id { get; set; }
        public string option_name { get; set; }
        public OptionValues[] option_values { get; set; }
    }
}
