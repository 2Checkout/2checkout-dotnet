using System;
using System.Collections.Generic;

namespace TwoCheckout
{
    public class SaleService
    {

        public Sale Retrieve(SaleRetrieveServiceOptions options)
        {
            String Result = TwoCheckoutUtil.Request("api/sales/detail_sale", "GET", "admin", options);
            return TwoCheckoutUtil.MapToObject<Sale>(Result, "sale");
        }

        public SaleList List(SaleListServiceOptions options = null)
        {
            String Result = TwoCheckoutUtil.Request("api/sales/list_sales", "GET", "admin", options);
            return TwoCheckoutUtil.MapToObject<SaleList>(Result);
        }

        public TwoCheckoutResponse Stop(SaleStopServiceOptions options)
        {
            String Result = null;
            if (options.sale_id != null)
            {
                Result = TwoCheckoutUtil.Request("api/sales/detail_sale", "GET", "admin", options);
                Dictionary<string, string> Active = TwoCheckoutUtil.Active(Result);
                if (Active.ContainsKey("lineitem_id0"))
                {
                    Result = TwoCheckoutUtil.StopActiveLineitems(Active);
                }
                else
                {
                    Result = "{ 'response_code': 'NOTICE', 'response_message': " + "'No active recurring lineitems.'" + " }";
                }
            }
            else
            {
                Result = TwoCheckoutUtil.Request("api/sales/stop_lineitem_recurring", "POST", "admin", options);
            }
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

        public TwoCheckoutResponse Refund(SaleRefundServiceOptions options)
        {
            String Result = null;
            if (options.lineitem_id != null)
            {
                Result = TwoCheckoutUtil.Request("api/sales/refund_lineitem", "POST", "admin", options);
            }
            else
            {
                Result = TwoCheckoutUtil.Request("api/sales/refund_invoice", "POST", "admin", options);
            }
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

        public TwoCheckoutResponse Comment(SaleCommentServiceOptions options)
        {
            String Result = TwoCheckoutUtil.Request("api/sales/create_comment", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

        public TwoCheckoutResponse Reauth(SaleReauthServiceOptions options)
        {
            String Result = TwoCheckoutUtil.Request("api/sales/reauth", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

        public TwoCheckoutResponse Ship(SaleShipServiceOptions options)
        {
            String Result = TwoCheckoutUtil.Request("api/sales/mark_shipped", "POST", "admin", options);
            return TwoCheckoutUtil.MapToObject<TwoCheckoutResponse>(Result);
        }

    }
}