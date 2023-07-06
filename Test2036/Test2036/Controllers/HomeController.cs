using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Test2036.Models;

namespace Test2036.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult BmiTable036(){
            double [] height = new double[13];
            double[] weight = new double[17];
            double[,] bmi = new double[13,17];

            for (int i = 0; i < 13; i++) {
                height[i] = 1.4 + (0.05 * i);
                
            }

            for (int i = 0; i < 17; i++) {
                weight[i] = 40 + (5 * i);
                
            }

            
            for (int i = 0; i < 17; i++) {
                for(int j = 0; j < 13; j++) {
                    bmi[j,i] = Math.Round((weight[i] / (height[j] * height[j])), 0);
                }
            }
            ViewBag.Height = height;
            ViewBag.Weight = weight;
            ViewBag.BMI = bmi;
            return View();
        }

        public IActionResult EmployeeCharity036() {
            IList<Employee036> listEmployees = new List<Employee036>() {
                new Employee036() {
                    EmpId = "007",
                    Name = "Hassan Sani",
                    Position = "Striker",
                    Campus = "MIIT",
                    Salary = 5300
                },
                new Employee036() {
                    EmpId = "001",
                    Name = "Jamal Nasir",
                    Position = "Defender",
                    Campus = "MIIT",
                    Salary = 4631
                },
                new Employee036() {
                    EmpId = "002",
                    Name = "Mokhtar Dahari",
                    Position = "Striker",
                    Campus = "BMI",
                    Salary = 3850
                },
                new Employee036() {
                    EmpId = "005",
                    Name = "R. Arumugam	",
                    Position = "Goalkeeper",
                    Campus = "MIIT",
                    Salary = 16205
                },
                new Employee036() {
                    EmpId = "004",
                    Name = "Santokh Singh",
                    Position = "Defender",
                    Campus = "BMI",
                    Salary = 2050
                },
                new Employee036() {
                    EmpId = "006",
                    Name = "Shukor Salleh",
                    Position = "Midfielder",
                    Campus = "MIIT",
                    Salary = 6631
                },
                new Employee036() {
                    EmpId = "003",
                    Name = "Soh Chin Aun",
                    Position = "Defender",
                    Campus = "MFI",
                    Salary = 10020
                }

            };

            ViewBag.Count = listEmployees.Count();
            ViewBag.HighestSalary = listEmployees.Max(x => x.Salary);
            ViewBag.LowestSalary = listEmployees.Min(x => x.Salary);
            ViewBag.AverageSalary = listEmployees.Average(x => x.Salary);
            ViewBag.AverageSalaryMIIT = listEmployees.Where(x => x.Campus == "MIIT").Average(x => x.Salary);
           

            return View(listEmployees);
        }

    }
}
