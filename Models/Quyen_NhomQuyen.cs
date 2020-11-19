using System.Collections.Generic;

namespace ExpMVCnetCoreSaleNoAuthent.Models
{
    public class Quyen_NhomQuyen
    {
        public int quyen_id { get; set; }
        public int nhomquyen_id { get; set; }
        public virtual ICollection<Quyen> Quyens { get; set; }
        public virtual ICollection<NhomQuyen> NhomQuyens { get; set; }
    }
}