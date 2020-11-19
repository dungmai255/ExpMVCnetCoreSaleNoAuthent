using System.Collections.Generic;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class User_NhomUser
    {
        public int user_id { get; set; }
        public int nhomuser_id { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<NhomUser> NhomUsers { get; set; }
    }
}