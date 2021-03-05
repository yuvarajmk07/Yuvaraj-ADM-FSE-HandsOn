using ListOffices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ListOffices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult ITOrganizations()
        {
            List<string> HyderabadOffices = new List<string>();
            HyderabadOffices.Add("Microsoft www.microsoft.com");
            HyderabadOffices.Add("CTS www.cognizant.com");
            HyderabadOffices.Add("Google");
            HyderabadOffices.Add("Amazon");
            HyderabadOffices.Add("TCS");
            return View((List<string>)HyderabadOffices);
        }
    }
}
