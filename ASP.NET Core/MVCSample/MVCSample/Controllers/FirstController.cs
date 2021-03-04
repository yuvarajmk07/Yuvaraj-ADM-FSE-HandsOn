using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSample.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult HelloWorld()
        {
            ViewBag.Data = "Hello World";
            return View();
        }
    }
}
