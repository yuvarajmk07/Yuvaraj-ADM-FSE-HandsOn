using ExceptionLogging.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionLogging.Controllers
{
  
    public class HomeController : Controller
    {
        private readonly ILoggerManager _logger;
        
        public HomeController(ILoggerManager logger)
        {
            _logger = logger;
        }
  
        public IActionResult Index()
        {
                throw new Exception("Exception Happened In Index and Handled in OnException");
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
    }
}
