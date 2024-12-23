using System.Diagnostics;
using HealthcareSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthcareSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoggingService _logger;

        public HomeController(ILoggingService logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
