using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class TwocheckoutConfig
    {
        public static String ApiUsername { get; set; }
        public static String ApiPassword { get; set; }
        public static String BaseUrl = "https://www.2checkout.com/";
        public static String SandboxBaseUrl = "https://sandbox.2checkout.com/";

        public TwocheckoutConfig() {}

        public TwocheckoutConfig(String apiusername, String apipassword)
        {
            ApiUsername = apiusername;
            ApiPassword = apipassword;
        }
    }
}
