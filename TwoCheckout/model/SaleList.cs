using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class SaleList
    {
        public PageInfo page_info { get; set; }
        public Sales[] sale_summary { get; set; }
    }
}
