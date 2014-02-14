using System;
using System.Collections.Generic;

namespace TwoCheckout
{
    public class ProductService
    {
            
        public Product Retrieve(ProductRetrieveServiceOptions options)
        {
            String Result = TwoCheckoutUtil.Request("api/products/detail_product", "GET", "admin", options);
            return TwoCheckoutUtil.MapToObject<Product>(Result, "product");
        }

        public TwoCheckoutResponse Create(ProductCreateServiceOptions options)
        {
            String Result = TwoCheckoutUtil.Request("api/products/create_product", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

        public ProductList List(ProductListServiceOptions options = null)
        {
            String Result = TwoCheckoutUtil.Request("api/products/list_products", "GET", "admin", options);
            return TwoCheckoutUtil.MapToObject<ProductList>(Result);
        }

        public TwoCheckoutResponse Update(ProductUpdateServiceOptions options = null)
        {
            String Result = TwoCheckoutUtil.Request("api/products/update_product", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

        public TwoCheckoutResponse Delete(ProductDeleteServiceOptions options = null)
        {
            String Result = TwoCheckoutUtil.Request("api/products/delete_product", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

    }
}
