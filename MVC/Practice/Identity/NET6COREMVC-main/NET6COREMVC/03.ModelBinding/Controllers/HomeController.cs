using _03.ModelBinding.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _03.ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Program.cs içerisinde bu action'un default yani
        //root url olduğunu belirttim.
        //https://localhost:7280/ bu isteğin karşılığı olarak
        //aşağıdaki action çalıştırılacak
        [HttpGet]
        //Bu action'u çalıştırmak için 
        //HTTP GET REQUEST kullandık!
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