using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class TwocheckoutKey
    {
        public static String PrivateKey { get; set; }

        public static String Mode { get; set; }

        public TwocheckoutKey() {}

        public TwocheckoutKey(String apikey, String mode)
        {
            PrivateKey = apikey;
            Mode = mode;
        }
    }
}
