using System;
using System.Collections.Generic;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class ProductModel
    {
        public int id { get; set; }
        public string code { get; set; }
        public string material { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public int? model_year { get; set; }
        public decimal? original_price { get; set; }
        public decimal? stock_price { get; set; }
        public decimal? store_price { get; set; }
        public decimal? sale_price { get; set; }
        public DateTime? stock_date { get; set; }
        public DateTime? store_date { get; set; }
        public virtual ICollection<CategoryModel> Categories { get; set; }
        public virtual StoreModel Store { get; set; }
        public virtual StockModel Stock { get; set; }
        public virtual ProductorModel Productor { get; set; }
    }
}