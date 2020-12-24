using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpMVCnetCoreSaleNoAuthent.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string address { get; set; }
    }
}