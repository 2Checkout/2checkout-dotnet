namespace TwoCheckout
{
    public class ProductListServiceOptions
    {
        public int? assigned_product_id { get; set; }
        public string vendor_product_id { get; set; }
        public string name { get; set; }
        public int? cur_page { get; set; }
        public int? pagesize { get; set; }
        public string sort_col { get; set; }
        public string sort_dir { get; set; }
    }
}
