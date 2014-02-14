using System;
using System.Collections.Generic;
using NUnit.Framework;
using TwoCheckout;

namespace UnitTests
{
    public class TestCharge
    {
        // Token
        String token = "YjdhN2Q0ZDItZDEzYS00Y2RlLWI3MDUtYjkzYzZlMjA2OWY2";

        // Set API Key
        [Test]
        public void _002_SetKey()
        {
            TwoCheckoutConfig.PrivateKey = "99999999999999999999";
            TwoCheckoutConfig.SellerID = "1817037";
        }

        // API Authorization
        [Test]
        public void _001_TestApiAuthorization()
        {
            try
            {
                var Service = new ChargeService();

                var Option1 = new AuthLineitemOption();
                Option1.optName = "Test Option 1";
                Option1.optValue = "Large";
                Option1.optSurcharge = (decimal)1.00;

                var Options = new List<AuthLineitemOption>();
                Options.Add(Option1);

                var LineItem1 = new AuthLineitem();
                LineItem1.name = "test item";
                LineItem1.price = (decimal)10.00;
                LineItem1.quantity = 1;
                LineItem1.options = Options;

                var Lineitems = new List<AuthLineitem>();
                Lineitems.Add(LineItem1);

                var Billing = new AuthBillingAddress();
                Billing.addrLine1 = "123 test st";
                Billing.city = "Columbus";
                Billing.zipCode = "43123";
                Billing.state = "OH";
                Billing.country = "USA";
                Billing.name = "Testing Tester";
                Billing.email = "example@2co.com";
                Billing.phone = "5555555555";

                var Shipping = new AuthShippingAddress();
                Shipping.addrLine1 = "123 test st";
                Shipping.city = "Columbus";
                Shipping.state = "OH";
                Shipping.country = "USA";
                Shipping.name = "Testing Tester";


                var Sale = new ChargeAuthorizeServiceOptions();
                Sale.lineItems = Lineitems;
                Sale.currency = "USD";
                Sale.merchantOrderId = "123";
                Sale.billingAddr = Billing;
                Sale.shippingAddr = Shipping;
                Sale.token = token;

                var Charge = new ChargeService();

                var result = Charge.Authorize(Sale);
                Assert.IsInstanceOf<Authorization>(result);
            }
            catch (TwoCheckoutException e)
            {
                Assert.IsInstanceOf<TwoCheckoutException>(e);
            }
        }
    }
}