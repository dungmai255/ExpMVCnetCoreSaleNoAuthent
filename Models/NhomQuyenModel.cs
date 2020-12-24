using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class NhomQuyenModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<QuyenModel> Quyens { get; set; }
        public virtual ICollection<NhomsUserModel> NhomsUsers { get; set; }
    }
}
