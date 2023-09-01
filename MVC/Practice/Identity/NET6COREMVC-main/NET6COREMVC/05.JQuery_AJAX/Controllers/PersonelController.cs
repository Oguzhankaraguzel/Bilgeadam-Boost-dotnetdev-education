using _05.JQuery_AJAX.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05.JQuery_AJAX.Controllers
{
	public class PersonelController : Controller
	{
		private static List<Personel> _personeller = new();
		public IActionResult Index()
		{
			return View(_personeller);
		}
		[HttpPost]
		public IActionResult Ekle(Personel personel)
		{
			if(ModelState.IsValid)
			{
				
				_personeller.Add(personel);
				return RedirectToAction("Index");
			}
			else
			{
				//return BadRequest("Lütfen kurallara uygun giriş sağlayınız!");
				return BadRequest(new {
					NameRule = "İsim minimum 5 karakter olmalıdır.",
					SurnameRule = "Soy isim minimum 5 karakter olmalıdır.",
					NumberRule = "5 haneli bir numara girmelisiniz!",
					SectionRule = "Bölüm minimum 5 karakter olmalıdır."
				});
			}
		}
	}
}
