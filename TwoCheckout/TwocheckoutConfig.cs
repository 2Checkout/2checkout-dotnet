using System;

namespace TwoCheckout
{
    public static class TwoCheckoutConfig
    {
        public static String ApiUsername { get; set; }
        public static String ApiPassword { get; set; }
        public static String SellerID { get; set; }
        public static String PrivateKey { get; set; }
        public static String SecretWord { get; set; }
        public static Boolean Sandbox { get; set; }
        public static Boolean Demo { get; set; }
        public static String BaseUrl = "https://www.2checkout.com/";
        public static String SandboxUrl = "https://sandbox.2checkout.com/";
        public static String Version = "4.0.0";
    }
}
