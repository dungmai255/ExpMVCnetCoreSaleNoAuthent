using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpMVCnetCoreSaleNoAuthent.ViewModels
{
    public class UserViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public DateTime? dob { get; set; }
        public string birthday { get { return dob.HasValue ? dob.Value.ToString("yyyy-MM-dd") : string.Empty; }}
        public string address { get; set; }
        public string image { get; set; }
        public int type_id { get; set; }
        public string identity_id { get; set; }
    }
}