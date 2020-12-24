using System.Collections.Generic;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class ProductorModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<ProductModel> Products { get; set; }
    }
}