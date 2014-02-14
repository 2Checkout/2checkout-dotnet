namespace TwoCheckout
{
    public class PayMethod
    {
        public string avs { get; set; }
        public string cvv { get; set; }
        public int? first_six_digits { get; set; }
        public int? last_two_digits { get; set; }
        public string method { get; set; }
    }
}
