using Microsoft.AspNetCore.Mvc;

namespace _06.EFDBFirst_AREAS.Areas.Manager.Controllers
{
	[Area("Manager")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
