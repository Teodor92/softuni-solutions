using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NumberRangeExample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NumberRangeExample.Controllers
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
            ViewBag.MagicalMessage = "Hey SoftUni";
            return View();
        }

        [HttpGet]
        public IActionResult Numbers(int id)
        {
            ViewBag.NumberRange = id;
            return View();
        }

        [HttpPost]
        public IActionResult Numbers(string myName)
        {
            int numeberRange = int.Parse(myName);
            ViewBag.NumberRange = numeberRange;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
