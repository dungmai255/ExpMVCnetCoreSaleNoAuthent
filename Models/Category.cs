using System.Collections.Generic;

namespace ExpMVCnetCoreSaleNoAuthent.DAL
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}