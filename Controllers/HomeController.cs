using DSTraningWebAPPAzure.Data;
using DSTraningWebAPPAzure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DSTraningWebAPPAzure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _db; 
        public HomeController(ILogger<HomeController> logger, DataContext db)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        { 
            var empList = _db.Employees;
            return View(empList);
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
