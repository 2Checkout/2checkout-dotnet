using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwoCheckout
{
    public class TwocheckoutApi
    {
        private String ApiUsername
        {
            get { return TwocheckoutConfig.ApiUsername; }
            set { TwocheckoutConfig.ApiUsername = value; }
        }

        private String ApiPassword
        {
            get { return TwocheckoutConfig.ApiPassword; }
            set { TwocheckoutConfig.ApiPassword = value; }
        }

        private String ApiKey
        {
            get { return TwocheckoutKey.PrivateKey; }
            set { TwocheckoutKey.PrivateKey = value; }
        }

        private String Mode
        {
            get { return TwocheckoutKey.Mode; }
            set { TwocheckoutKey.Mode = value; }
        }

        public String ApiGet(String urlSuffix, Dictionary<string, string> args = null)
        {
            String Url = TwocheckoutConfig.BaseUrl + urlSuffix;
            String QueryString = null;
            if (args != null)
            {
                QueryString = TwocheckoutUtil.ConstructQueryString(args);
            }
            String RequestUrl = Url + "?" + QueryString;
            String Result = null;
            HttpWebRequest Request;
            HttpWebResponse Response = null;

            try
            {
                Request = WebRequest.Create(RequestUrl) as HttpWebRequest;
                ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
                Request.Credentials = new NetworkCredential(ApiUsername, ApiPassword);
                Request.Accept = "application/json";
                Request.UserAgent = "2Checkout .NET/0.1.0";
                using (Response = Request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(Response.GetResponseStream());
                    Result = reader.ReadToEnd();
                    return Result;
                }
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (HttpWebResponse errorResponse = (HttpWebResponse)wex.Response)
                    {
                        StreamReader reader = new StreamReader(errorResponse.GetResponseStream());
                        Result = reader.ReadToEnd();
                        throw new TwocheckoutException(Result);
                    }
                    throw;
                }
                return Result;
            }
            finally
            {
                if (Response != null) { Response.Close(); }
            }
        }

        public String ApiPost(String urlSuffix, Dictionary<string, string> args)
        {
            String Url = TwocheckoutConfig.BaseUrl + urlSuffix;
            String Data = TwocheckoutUtil.ConstructQueryString(args);
            Uri Address = new Uri(Url);
            String Result = null;
            HttpWebRequest Request;
            HttpWebResponse Response = null;

            try
            {
                Request = WebRequest.Create(Address) as HttpWebRequest;
                Request.Credentials = new NetworkCredential(ApiUsername, ApiPassword);
                Request.Method = "POST";
                Request.UserAgent = "2Checkout .NET/0.1.0";
                Request.ContentType = "application/x-www-form-urlencoded";
                Request.Accept = "application/json";
                byte[] byteData = UTF8Encoding.UTF8.GetBytes(Data.ToString());
                Request.ContentLength = byteData.Length;
                using (Stream postStream = Request.GetRequestStream())
                {
                    postStream.Write(byteData, 0, byteData.Length);
                }
                using (Response = Request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(Response.GetResponseStream());
                    Result = reader.ReadToEnd();
                }
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (HttpWebResponse ErrorResponse = (HttpWebResponse)wex.Response)
                    {
                        StreamReader Reader = new StreamReader(ErrorResponse.GetResponseStream());
                        Result = Reader.ReadToEnd();
                        throw new TwocheckoutException(Result);
                    }
                    throw;
                }
                return Result;
            }
            finally
            {
                if (Response != null) { Response.Close(); }
            }
            return Result;
        }

        public String ApiJson(String urlSuffix, Dictionary<string, object> args)
        {
            String Url = null;
            if (Mode == "sandbox")
            {
                Url = TwocheckoutConfig.SandboxBaseUrl + urlSuffix;
            }
            else
            {
                Url = TwocheckoutConfig.BaseUrl + urlSuffix;
            }
            args.Add("privateKey", ApiKey);
            String Data = TwocheckoutUtil.ConvertToJson(args);
            Uri Address = new Uri(Url);
            String Result = null;
            HttpWebRequest Request;
            HttpWebResponse Response = null;

            try
            {
                Request = WebRequest.Create(Address) as HttpWebRequest;
                Request.Method = "POST";
                Request.UserAgent = "2Checkout .NET/0.1.0";
                Request.ContentType = "application/json";
                Request.Accept = "application/json";
                byte[] byteData = UTF8Encoding.UTF8.GetBytes(Data.ToString());
                Request.ContentLength = byteData.Length;
                using (Stream postStream = Request.GetRequestStream())
                {
                    postStream.Write(byteData, 0, byteData.Length);
                }
                using (Response = Request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(Response.GetResponseStream());
                    Result = reader.ReadToEnd();
                }
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (HttpWebResponse ErrorResponse = (HttpWebResponse)wex.Response)
                    {
                        StreamReader Reader = new StreamReader(ErrorResponse.GetResponseStream());
                        Result = Reader.ReadToEnd();
                        throw new TwocheckoutException(Result);
                    }
                    throw;
                }
                return Result;
            }
            finally
            {
                if (Response != null) { Response.Close(); }
            }
            return Result;
        }
    }
}
