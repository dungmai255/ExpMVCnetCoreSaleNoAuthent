using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class Quyen
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Quyen_NhomQuyen> Quyen_NhomQuyens { get; set; }
    }
}
