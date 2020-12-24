using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpMVCnetCoreSaleNoAuthent.ViewModels
{
    public class OrderItemViewModel : BaseViewModel
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int product_id { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> discount { get; set; }
    }
}