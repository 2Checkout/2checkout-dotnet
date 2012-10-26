using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TwoCheckout;

namespace UnitTests
{
    public class TestProduct
    {
        // Product
        public String product_id { get; set; }

        // Set API Credentials
        [Test]
        public void _001_SetUser()
        {
            TwocheckoutConfig.ApiUsername = "APIuser1817037";
            TwocheckoutConfig.ApiPassword = "APIpass1817037";
        }

        // Create Product
        [Test]
        public void _002_TestProductCreate()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("name", "TestProduct");
            dictionary.Add("vendor_product_id", "TestProduct123");
            dictionary.Add("price", "0.01");
            var result = TwocheckoutProduct.Create(dictionary);
            product_id = result.product_id;
            Assert.IsInstanceOf<TwocheckoutResponse>(result);
        }

        // Retrieve Product
        [Test]
        public void _003_TestProductRetrieve()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("product_id", product_id);
            var result = TwocheckoutProduct.Retrieve(dictionary);
            Assert.IsInstanceOf<Product>(result);
        }

        // List Products
        [Test]
        public void _004_TestProductList()
        {
            var result = TwocheckoutProduct.List();
            Assert.IsInstanceOf<ProductList>(result);
        }

        // Update Product
        [Test]
        public void _005_TestProductUpdate()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("product_id", product_id);
            dictionary.Add("vendor_product_id", "TestProduct123");
            dictionary.Add("price", "0.01");
            var result = TwocheckoutProduct.Update(dictionary);
            Assert.IsInstanceOf<TwocheckoutResponse>(result);
        }

        // Delete Product
        [Test]
        public void _006_TestProductDelete()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("product_id", product_id);
            var result = TwocheckoutProduct.Delete(dictionary);
            Assert.IsInstanceOf<TwocheckoutResponse>(result);
        }
    }
}
