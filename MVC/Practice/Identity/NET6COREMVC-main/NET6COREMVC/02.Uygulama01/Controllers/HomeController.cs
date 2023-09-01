using _02.Uygulama01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _02.Uygulama01.Controllers
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


    }
}