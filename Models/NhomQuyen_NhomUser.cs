using System.Collections.Generic;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class NhomQuyen_NhomUser
    {
        public int nhomquyen_id { get; set; }
        public int nhomuser_id { get; set; }
        public virtual ICollection<NhomUser> NhomUsers { get; set; }
        public virtual ICollection<NhomQuyen> NhomQuyens { get; set; }
    }
}