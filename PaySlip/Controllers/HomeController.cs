using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaySlip.Services;

namespace PaySlip.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAPIService _aPIService;
        public HomeController(IAPIService aPIService)
        {
            _aPIService = aPIService;
        }
        public IActionResult Index()
        {
            ViewBag.Employees = _aPIService.GetEmployees();
            return View();
        }
        public IActionResult AddEmp()
        {
            return View();
        }
        public IActionResult PaySlip()
        {
            return View();
        }
    }
}
