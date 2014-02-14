using System;
using System.Collections.Generic;

namespace TwoCheckout
{
    public class OptionService
    {

        public Option Retrieve(OptionRetrieveServiceOptions options)
        {
            String Result = TwoCheckoutUtil.Request("api/products/detail_option", "GET", "admin", options);
            Options OptionResult = TwoCheckoutUtil.MapToObject<Options>(Result);
            return OptionResult.option[0];
        }

        public OptionList List(OptionListServiceOptions options = null)
        {
            String Result = TwoCheckoutUtil.Request("api/products/list_options", "GET", "admin", options);
            return TwoCheckoutUtil.MapToObject<OptionList>(Result);
        }

        public TwoCheckoutResponse Create(OptionCreateServiceOptions options)
        {
            String Result = TwoCheckoutUtil.Request("api/products/create_option", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

        public TwoCheckoutResponse Update(OptionUpdateServiceOptions options = null)
        {
            String Result = TwoCheckoutUtil.Request("api/products/update_option", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

        public TwoCheckoutResponse Delete(OptionDeleteServiceOptions options = null)
        {
            String Result = TwoCheckoutUtil.Request("api/products/delete_option", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

    }
}
