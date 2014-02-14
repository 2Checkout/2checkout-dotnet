namespace TwoCheckout
{
    public class OptionListServiceOptions
    {
        public string option_name { get; set; }
        public string option_value_name { get; set; }
        public int? cur_page { get; set; }
        public int? pagesize { get; set; }
        public string sort_col { get; set; }
        public string sort_dir { get; set; }
    }
}
