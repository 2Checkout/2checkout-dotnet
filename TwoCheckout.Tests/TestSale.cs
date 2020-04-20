using System;
using System.Collections.Generic;
using NUnit.Framework;
using TwoCheckout;

namespace Twocheckout.Tests
{
    public class TestSale
    {
        // Sale Info
        long sale_id = 4828598838;
        long lineitem_id = 4828598922;
        long invoice_id = 4828598847;

        // Set API Credentials
        [Test]
        public void _001_SetUser()
        {
            TwoCheckoutConfig.ApiUsername = "APIuser1817037";
            TwoCheckoutConfig.ApiPassword = "APIpass1817037";
        }

        // List Sales
        [Test]
        public void _002_TestSaleList()
        {
            try
            {
                var ServiceObject = new SaleService();
                var ArgsObject = new SaleListServiceOptions();
                ArgsObject.customer_email = "noreply@2co.com";
                var result = ServiceObject.List(ArgsObject);
                Assert.IsInstanceOf<SaleList>(result);
            }
            catch (TwoCheckoutException e)
            {
                Assert.IsInstanceOf<TwoCheckoutException>(e);
            }
        }

        // Detail Sale
        [Test]
        public void _003_TestSaleRetrieve()
        {
            try
            {
                var ServiceObject = new SaleService();
                var ArgsObject = new SaleRetrieveServiceOptions();
                ArgsObject.sale_id = sale_id;
                var result = ServiceObject.Retrieve(ArgsObject);
                Assert.IsInstanceOf<Sale>(result);
            }
            catch (TwoCheckoutException e)
            {
                Assert.IsInstanceOf<TwoCheckoutException>(e);
            }
        }

        // Sale Stop Recurring Sale
        [Test]
        public void _004_TestSaleStop()
        {
            try
            {
                var ServiceObject = new SaleService();
                var ArgsObject = new SaleStopServiceOptions();
                ArgsObject.sale_id = sale_id;
                var result = ServiceObject.Stop(ArgsObject);
                Assert.IsInstanceOf<TwoCheckoutResponse>(result);
            }
            catch (TwoCheckoutException e)
            {
                Assert.IsInstanceOf<TwoCheckoutException>(e);
            }
        }

        // Sale Stop Recurring Lineitem
        [Test]
        public void _005_TestLineitemStop()
        {
            try
            {
                var ServiceObject = new SaleService();
                var ArgsObject = new SaleStopServiceOptions();
                ArgsObject.lineitem_id = lineitem_id;
                var result = ServiceObject.Stop(ArgsObject);
                Assert.IsInstanceOf<TwoCheckoutResponse>(result);
            }
            catch (TwoCheckoutException e)
            {
                Assert.IsInstanceOf<TwoCheckoutException>(e);
            }
        }

        // Sale Refund Sale
        [Test]
        public void _006_TestSaleRefund()
        {
            try
            {
                var ServiceObject = new SaleService();
                var ArgsObject = new SaleRefundServiceOptions();
                ArgsObject.sale_id = sale_id;
                ArgsObject.comment = "test refund";
                ArgsObject.category = 5;
                var result = ServiceObject.Refund(ArgsObject);
                Assert.IsInstanceOf<TwoCheckoutResponse>(result);
            }
            catch (TwoCheckoutException e)
            {
                Assert.IsInstanceOf<TwoCheckoutException>(e);
            }
        }

        // Sale Refund Invoice
        [Test]
        public void _007_TestInvoiceRefund()
        {
            try
            {
                var ServiceObject = new SaleService();
                var ArgsObject = new SaleRefundServiceOptions();
                ArgsObject.invoice_id = invoice_id;
                ArgsObject.comment = "test refund";
                ArgsObject.category = 5;
                var result = ServiceObject.Refund(ArgsObject);
                Assert.IsInstanceOf<TwoCheckoutResponse>(result);
            }
            catch (TwoCheckoutException e)
            {
                Assert.IsInstanceOf<TwoCheckoutException>(e);
            }
        }

        // Sale Refund Linitem
        [Test]
        public void _008_TestLineitemRefund()
        {
            try
            {
                var ServiceObject = new SaleService();
                var ArgsObject = new SaleRefundServiceOptions();
                ArgsObject.lineitem_id = lineitem_id;
                ArgsObject.comment = "test refund";
                ArgsObject.category = 5;
                var result = ServiceObject.Refund(ArgsObject);
                Assert.IsInstanceOf<TwoCheckoutResponse>(result);
            }
            catch (TwoCheckoutException e)
            {
                Assert.IsInstanceOf<TwoCheckoutException>(e);
            }
        }

        // Sale Ship
        [Test]
        public void _010_TestSaleShipped()
        {
            try
            {
                var ServiceObject = new SaleService();
                var ArgsObject = new SaleShipServiceOptions();
                ArgsObject.sale_id = sale_id;
                var result = ServiceObject.Ship(ArgsObject);
                Assert.IsInstanceOf<TwoCheckoutResponse>(result);
            }
            catch (TwoCheckoutException e)
            {
                Assert.IsInstanceOf<TwoCheckoutException>(e);
            }
        }

        // Sale Comment
        [Test]
        public void _011_TestSaleComment()
        {
            try
            {
                var ServiceObject = new SaleService();
                var ArgsObject = new SaleCommentServiceOptions();
                ArgsObject.sale_id = sale_id;
                ArgsObject.sale_comment = "Test";
                var result = ServiceObject.Comment(ArgsObject);
                Assert.IsInstanceOf<TwoCheckoutResponse>(result);
            }
            catch (TwoCheckoutException e)
            {
                Assert.IsInstanceOf<TwoCheckoutException>(e);
            }
        }
    }
}
