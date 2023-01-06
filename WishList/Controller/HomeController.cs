using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Index();
        }

        public IActionResult Error()
        {
            return Error();
        }
    }
}
