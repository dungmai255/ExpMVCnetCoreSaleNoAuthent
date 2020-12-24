using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpMVCnetCoreSaleNoAuthent.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        public int id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public byte order_status { get; set; }
        public System.DateTime order_date { get; set; }
        public System.DateTime required_date { get; set; }
        public Nullable<int> store_id { get; set; }
        public Nullable<int> staff_id { get; set; }
    }
}