using _05.JQuery_AJAX.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05.JQuery_AJAX.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()  
		{

			return View();
		}

		[HttpPost]
		public IActionResult Index(SystemUser user)  
		{
			if (ModelState.IsValid)  
				return RedirectToAction("Privacy","Home");  

			return View();
		}
	}
}
