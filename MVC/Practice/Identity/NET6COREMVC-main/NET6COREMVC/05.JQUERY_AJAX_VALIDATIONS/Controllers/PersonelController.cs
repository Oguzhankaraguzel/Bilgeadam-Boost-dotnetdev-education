using _05.JQUERY_AJAX_VALIDATIONS.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05.JQUERY_AJAX_VALIDATIONS.Controllers
{
    public class PersonelController : Controller
    {
        private static List<Personel> _personeller = new();
        public IActionResult Index()
        {
            return View(_personeller);
        }

        public IActionResult Goster()
        {
            return Ok(_personeller);
        }

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        //Personel/Ekle
        public IActionResult Ekle(Personel personel)
        {
            if (ModelState.IsValid)
            {
                _personeller.Add(personel);
                //Sunucu içi yönlendirme
                return RedirectToAction("Index");
            }
            else
            {
                //return BadRequest("Lütfen bilgileri istenilen formatta giriniz!");
                return BadRequest(new { NameRule = "En az 5 karakter olmalıdır!", SurnameRule = "En az 5 karakter olmalıdır!", NumberRule = "4 haneli olmalıdır!", SectionRule = "En az 5 karakter olmalıdır!" });
            }

        }

    }
}
