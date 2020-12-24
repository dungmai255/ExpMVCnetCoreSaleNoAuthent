using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class NhomsUserModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<UserModel> Users { get; set; }
        public virtual ICollection<NhomQuyenModel> NhomQuyens { get; set; }

    }
}
