using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<User_NhomUser> User_NhomUsers { get; set; }
    }
}
