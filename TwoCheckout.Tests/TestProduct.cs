using System;
using System.Collections.Generic;
using NUnit.Framework;
using TwoCheckout;

namespace Twocheckout.Tests
{
    public class TestProduct
    {
        // Product
        public long? product_id { get; set; }

        // Set API Credentials
        [Test]
        public void _001_SetUser()
        {
            TwoCheckoutConfig.ApiUsername = "APIuser1817037";
            TwoCheckoutConfig.ApiPassword = "APIpass1817037";
        }

        // Create Product
        [Test]
        public void _002_TestProductCreate()
        {
            var ServiceObject = new ProductService();
            var ArgsObject = new ProductCreateServiceOptions();
            ArgsObject.approved_url = "http://www.example.com";
            ArgsObject.description = "Test";
            ArgsObject.duration = "1 Year";
            ArgsObject.handling = (decimal)1.00;
            ArgsObject.long_description = "Test";
            ArgsObject.name = "Test Product";
            ArgsObject.price = (decimal)2.00;
            ArgsObject.recurrence = "1 Month";
            ArgsObject.recurring = 1;
            ArgsObject.startup_fee = (decimal)0.50;
            ArgsObject.tangible = 1;
            ArgsObject.vendor_product_id = "test123";
            ArgsObject.weight = (decimal)1.50;
            var result = ServiceObject.Create(ArgsObject);
            product_id = result.product_id;
            Assert.IsInstanceOf<TwoCheckoutResponse>(result);
        }

        // Retrieve Product
        [Test]
        public void _003_TestProductRetrieve()
        {
            var ServiceObject = new ProductService();
            var ArgsObject = new ProductRetrieveServiceOptions();
            ArgsObject.product_id = product_id;
            var result = ServiceObject.Retrieve(ArgsObject);
            Assert.IsInstanceOf<Product>(result);
        }

        // List Products
        [Test]
        public void _004_TestProductList()
        {
            var ServiceObject = new ProductService();
            var ArgsObject = new ProductListServiceOptions();
            ArgsObject.pagesize = 5;
            var result = ServiceObject.List(ArgsObject);
            Assert.IsInstanceOf<ProductList>(result);
        }

        // Delete Product
        [Test]
        public void _006_TestProductDelete()
        {
            var ServiceObject = new ProductService();
            var ArgsObject = new ProductDeleteServiceOptions();
            ArgsObject.product_id = product_id;
            var result = ServiceObject.Delete(ArgsObject);
            Assert.IsInstanceOf<TwoCheckoutResponse>(result);
        }
    }
}
