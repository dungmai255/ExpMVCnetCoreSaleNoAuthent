using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpMVCnetCoreSaleNoAuthent.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public int id { get; set; }
        public string code { get; set; }
        public Nullable<int> category_id { get; set; }
        public Nullable<int> productor_id { get; set; }
        public Nullable<int> stock_id { get; set; }
        public Nullable<int> store_id { get; set; }
        public string material { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public string model_year { get; set; }
        public Nullable<decimal> original_price { get; set; }
        public Nullable<decimal> stock_price { get; set; }
        public Nullable<decimal> store_price { get; set; }
        public Nullable<decimal> sale_price { get; set; }
    }
}