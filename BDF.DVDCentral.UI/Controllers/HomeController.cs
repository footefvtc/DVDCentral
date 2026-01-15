using Microsoft.AspNetCore.Mvc;
using BDF.DVDCentral.UI.Models;
using System.Diagnostics;

namespace BDF.DVDCentral.UI.Controllers
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
            ViewBag.Title = "DVDCentral Home Page";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Title = "DVDCentral Privacy Page";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}