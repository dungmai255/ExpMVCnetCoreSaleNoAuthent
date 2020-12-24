using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpMVCnetCoreSaleNoAuthent.ViewModels
{
    public class BaseViewModel
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}