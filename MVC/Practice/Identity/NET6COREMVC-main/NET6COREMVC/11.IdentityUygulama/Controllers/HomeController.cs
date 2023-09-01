using _11.IdentityUygulama.Context;
using _11.IdentityUygulama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _11.IdentityUygulama.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly NorthwindContext _dbContext;
		public HomeController(ILogger<HomeController> logger, NorthwindContext dbContext)
		{
			_logger = logger;
			//SOLID (D - DEPENDENCY INJECTION)
			//DEPENDENCY INJENCTION
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			
			return View(_dbContext.Products.FirstOrDefault());
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

		public void Test1()
		{
			//_dbContext.Products.Where(prod => prod.ProductId == 1).FirstOrDefault();
			_dbContext.Products.Where(KontrolEt).FirstOrDefault();
		}

		public bool KontrolEt(Product prod)
		{
			return prod.ProductId == 1;
		}
		public void Test2()
		{

		}

	}
}