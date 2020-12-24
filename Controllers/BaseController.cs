using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpMVCnetCoreSaleNoAuthent.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            //ViewBag.User = JsonConvert.DeserializeObject<UserViewModel>(JsonConvert.SerializeObject(new UserController().Details(1)));
        }
    }
}
