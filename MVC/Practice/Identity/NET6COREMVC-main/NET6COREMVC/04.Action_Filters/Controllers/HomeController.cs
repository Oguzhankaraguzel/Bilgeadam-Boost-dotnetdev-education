using _04.Action_Filters.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _04.Action_Filters.Controllers
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
        [Route("/bulunamadi")]
        public IActionResult NotFound404()
        {
            return View();
        }

        [Route("/NotFound")]
        public IActionResult NotFoundYonlen()
        {
            return RedirectToAction("NotFound404");
        }
    }
}