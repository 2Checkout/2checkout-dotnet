using System;
using System.Collections.Generic;
using NUnit.Framework;
using TwoCheckout;

namespace Twocheckout.Tests
{
    public class TestCharge
    {
        // Token
        String token = "token";

        // Set API Key
        [Test]
        public void _002_SetKey()
        {
            TwoCheckoutConfig.PrivateKey = "private-key";
            TwoCheckoutConfig.SellerID = "seller-id";
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
                Billing.name = "John Doe";
                Billing.email = "example@2co.com";
                Billing.phoneNumber = "5555555555";

                var Shipping = new AuthShippingAddress();
                Shipping.addrLine1 = "123 test st";
                Shipping.city = "Columbus";
                Shipping.state = "OH";
                Shipping.zipCode = "43123";
                Shipping.country = "USA";
                Shipping.name = "John Doe";


                var Sale = new ChargeAuthorizeServiceOptions();
                Sale.lineItems = Lineitems;
                Sale.currency = "USD";
                Sale.merchantOrderId = "123";
                Sale.billingAddr = Billing;
                Sale.shippingAddr = Shipping;
                Sale.token = token;
                Sale.returnUrl = "http://www.2checkout.com/documentation";
                Sale.demo = true;
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
