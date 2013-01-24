using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TwoCheckout;

namespace UnitTests
{
    public class TestSale
    {
        // Sales
        String sale_id = "4828598838";
        String lineitem_id = "4828598922";
        String invoice_id = "4828598847";

        // Set API Credentials
        [Test]
        public void _001_SetUser()
        {
            TwocheckoutConfig.ApiUsername = "APIuser1817037";
            TwocheckoutConfig.ApiPassword = "APIpass1817037";
        }

        // List Sales
        [Test]
        public void _002_TestSaleList()
        {
            try
            {
                var result = TwocheckoutSale.List();
                Assert.IsInstanceOf<SaleList>( result );
            }
            catch (TwocheckoutException e)
            {
                Assert.IsInstanceOf<TwocheckoutException>(e);
            }
        }

        // Detail Sale
        [Test]
        public void _003_TestSaleRetrieve()
        {
            try
            {
                var dictionary = new Dictionary<string, string>();
                dictionary.Add("sale_id", sale_id);
                var result = TwocheckoutSale.Retrieve(dictionary);
                Assert.IsInstanceOf<Sale>(result);
            }
                catch (TwocheckoutException e)
            {
                Assert.IsInstanceOf<TwocheckoutException>(e);
            }
        }

        // Sale Stop Recurring Sale
        [Test]
        public void _004_TestSaleStop()
        {
            try
            {
                var dictionary = new Dictionary<string, string>();
                dictionary.Add("sale_id", sale_id);
                var result = TwocheckoutSale.Stop(dictionary);
                Assert.IsInstanceOf<TwocheckoutResponse>(result);
            }
            catch (TwocheckoutException e)
            {
                Assert.IsInstanceOf<TwocheckoutException>(e);
            }
        }

        // Sale Stop Recurring Lineitem
        [Test]
        public void _005_TestLineitemStop()
        {
            try
            {
                var dictionary = new Dictionary<string, string>();
                dictionary.Add("linetiem_id", lineitem_id);
                var result = TwocheckoutSale.Stop(dictionary);
                Assert.IsInstanceOf<TwocheckoutResponse>(result);
            }
                catch (TwocheckoutException e)
            {
                Assert.IsInstanceOf<TwocheckoutException>(e);
            }
        }

        // Sale Refund Sale
        [Test]
        public void _006_TestSaleRefund()
        {
            try
            {
                var dictionary = new Dictionary<string, string>();
                dictionary.Add("sale_id", sale_id);
                dictionary.Add("comment", "test refund");
                dictionary.Add("category", "5");
                var result = TwocheckoutSale.Refund(dictionary);
                Assert.IsInstanceOf<TwocheckoutResponse>(result);
            }
            catch (TwocheckoutException e)
            {
                Assert.IsInstanceOf<TwocheckoutException>(e);
            }
        }

        // Sale Refund Invoice
        [Test]
        public void _007_TestInvoiceRefund()
        {
            try
            {
                var dictionary = new Dictionary<string, string>();
                dictionary.Add("invoice_id", invoice_id);
                dictionary.Add("comment", "test refund");
                dictionary.Add("category", "5");
                var result = TwocheckoutSale.Refund(dictionary);
                Assert.IsInstanceOf<TwocheckoutResponse>(result);
            }
            catch (TwocheckoutException e)
            {
                Assert.IsInstanceOf<TwocheckoutException>(e);
            }
        }

        // Sale Refund Linitem
        [Test]
        public void _008_TestLineitemRefund()
        {
            try
            {
                var dictionary = new Dictionary<string, string>();
                dictionary.Add("lineitem_id", lineitem_id);
                dictionary.Add("comment", "test refund");
                dictionary.Add("category", "5");
                var result = TwocheckoutSale.Refund(dictionary);
                Assert.IsInstanceOf<TwocheckoutResponse>(result);
            }
            catch (TwocheckoutException e)
            {
                Assert.IsInstanceOf<TwocheckoutException>(e);
            }
        }

        // Sale Reauth
        [Test]
        public void _009_TestSaleReauth()
        {
            try
            {
                var dictionary = new Dictionary<string, string>();
                dictionary.Add("sale_id", sale_id);
                var result = TwocheckoutSale.Reauth(dictionary);
                Assert.IsInstanceOf<TwocheckoutResponse>(result);
            }
            catch (TwocheckoutException e)
            {
                Assert.IsInstanceOf<TwocheckoutException>(e);
            }
        }

        // Sale Ship
        [Test]
        public void _010_TestSaleShipped()
        {
            try
            {
                var dictionary = new Dictionary<string, string>();
                dictionary.Add("sale_id", sale_id);
                dictionary.Add("tracking_number", "123");
                var result = TwocheckoutSale.Ship(dictionary);
                Assert.IsInstanceOf<TwocheckoutResponse>(result);
            }
            catch (TwocheckoutException e)
            {
                Assert.IsInstanceOf<TwocheckoutException>(e);
            }
        }

        // Sale Comment
        [Test]
        public void _011_TestSaleComment()
        {
            try
            {
                var dictionary = new Dictionary<string, string>();
                dictionary.Add("sale_id", sale_id);
                dictionary.Add("sale_comment", "Test");
                var result = TwocheckoutSale.Comment(dictionary);
                Assert.IsInstanceOf<TwocheckoutResponse>(result);
            }
            catch (TwocheckoutException e)
            {
                Assert.IsInstanceOf<TwocheckoutException>(e);
            }
        }
    }
}