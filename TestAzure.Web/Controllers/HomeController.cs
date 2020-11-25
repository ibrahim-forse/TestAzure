using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestAzure.Web.Models;

namespace TestAzure.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        TestContext _db;
        public HomeController(ILogger<HomeController> logger, TestContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var datalist = _db.DatabaseModels.ToList();
            return View(datalist);
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
