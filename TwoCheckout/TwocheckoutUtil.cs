using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace TwoCheckout
{
    public class TwocheckoutUtil
    {
        public static Dictionary<string, string> Active(String response)
        {
            JObject Sale = JObject.Parse(response);
            var Active = new Dictionary<string, string>();
            try
            {
                JToken Invoices = Sale["sale"]["invoices"];
                int i = 0;
                JArray Lineitems;
                foreach (JObject invoice in Invoices)
                {
                    Lineitems = (JArray)invoice["lineitems"];
                    foreach (JObject lineitem in Lineitems)
                    {
                        if ((string)lineitem["billing"]["recurring_status"] == "active")
                        {
                            Active.Add("lineitem_id" + i, (string)lineitem["billing"]["lineitem_id"]);
                            i++;
                        }
                    }
                }
                return Active;
            }
            catch (NullReferenceException)
            {
                return Active;
            }
        }

        public static String Md5Hash(string input)
        {
            MD5CryptoServiceProvider Md5Hasher = new MD5CryptoServiceProvider();
            byte[] Data = Md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder SBuilder = new StringBuilder();
            for (int i = 0; i < Data.Length; i++)
            {
                SBuilder.Append(Data[i].ToString("x2"));
            }
            return SBuilder.ToString().ToUpper();
        }

        public static String ConstructQueryString(Dictionary<string, string> parameters)
        {
            List<string> Items = new List<string>();

            foreach (var name in parameters)
                Items.Add(String.Concat(name.Key, "=", name.Value));

            return String.Join("&", Items.ToArray());
        }

        public static String ConvertToJson(Dictionary<string, object> parameters)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(parameters);
        }
    }
}
