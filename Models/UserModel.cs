using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string identityNumber { get; set; }
        public string address { get; set; }
        public DateTime birthday { get; set; }
        public string note { get; set; }
        public virtual ICollection<NhomsUserModel> NhomUsers { get; set; }
        public virtual ICollection<UserKindModel> UserKinds { get; set; }
    }
}
