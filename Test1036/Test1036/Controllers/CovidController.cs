using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1036.Models;

namespace Test1036.Controllers
{
    public class CovidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CovidResponse036()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CovidResponse036(CovidDiagnosis input)
        {
            return View("CovidResponseResult036", input);
        }
    }
}
