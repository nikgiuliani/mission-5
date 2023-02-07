using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcCSharp.Models;

namespace mvcCSharp.Controllers
{
    public class HomePageController : Controller 
    {
        public IActionResult Index() 
        {
            return View();
        }
        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculator(CalculatorModel model)
        {
            return View();
        }
    }
}