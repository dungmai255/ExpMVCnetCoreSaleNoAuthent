using System.Collections.Generic;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class StoreModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public virtual ICollection<ProductModel> Products { get; set; }
    }
}