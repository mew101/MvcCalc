using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCalc.Models;

namespace MvcCalc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Total(int val1, int val2, String calc)
        {
            int total = 0;
            switch (calc)
            {
                case "+":
                    total = val1 + val2;
                    break;
                case "-":
                    total = val1 - val2;
                    break;
                case "*":
                    total = val1 * val2;
                    break;
                case "/":
                    total = val1 / val2;
                    break;
                default:
                    break;
            }
            return View();
        }
    }
}
