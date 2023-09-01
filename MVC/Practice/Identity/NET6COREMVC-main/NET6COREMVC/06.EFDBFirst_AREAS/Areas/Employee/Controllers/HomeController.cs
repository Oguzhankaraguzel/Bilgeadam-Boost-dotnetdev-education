using Microsoft.AspNetCore.Mvc;

namespace _06.EFDBFirst_AREAS.Areas.Employee.Controllers
{
	[Area("Employee")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult About()
		{
			return View();
		}
	}
}
