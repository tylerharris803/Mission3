using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstASPNETWebAppHarris.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstASPNETWebAppHarris.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeCalculator(GradeCalculatorModel model)
        {
            return View();

        }
    }
}
