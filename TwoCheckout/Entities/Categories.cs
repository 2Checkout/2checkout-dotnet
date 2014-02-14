namespace TwoCheckout
{
    public class Categories
    {
        public int? category_id { get; set; }
        public string name { get; set; }
        public int? parent_id { get; set; }
        public string description { get; set; }
        public string parent_name { get; set; }
    }
}
