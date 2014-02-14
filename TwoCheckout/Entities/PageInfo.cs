namespace TwoCheckout
{
    public class PageInfo
    {
        public int? cur_page { get; set; }
        public int? first_entry { get; set; }
        public int? first_page { get; set; }
        public string first_page_url { get; set; }
        public int? last_entry { get; set; }
        public int? last_page { get; set; }
        public string last_page_url { get; set; }
        public int? next_page { get; set; }
        public int? pagesize { get; set; }
        public int? previous_page { get; set; }
        public int? total_entries { get; set; }
    }
}