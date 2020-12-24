using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class UserKindModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<UserModel> Users { get; set; }
    }
}
