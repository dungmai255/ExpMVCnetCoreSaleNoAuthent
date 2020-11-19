using System.Collections.Generic;

namespace ExpMVCnetCoreSaleNoAuthent.DAL
{
    public class Store
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}