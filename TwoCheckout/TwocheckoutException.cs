using System;
using System.Net;

namespace TwoCheckout
{
    public class TwocheckoutException : ApplicationException
    {
        public String response_message { get; set; }


        public TwocheckoutException(String message)
            : base(message)
        {
            response_message = message;
        }
    }
}
