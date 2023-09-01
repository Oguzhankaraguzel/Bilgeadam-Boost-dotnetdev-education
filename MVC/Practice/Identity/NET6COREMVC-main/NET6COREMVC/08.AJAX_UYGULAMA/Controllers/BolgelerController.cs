using _07.ROUTING.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _08.AJAX_UYGULAMA.Controllers
{
    public class BolgelerController : Controller
    {
        public IActionResult Index()
        {
            List<SelectListItem> bolgeler = DB.Bolgeler().Select(bolge => new SelectListItem() {Text = bolge.BolgeAd, Value = bolge.Id.ToString() }).ToList();
            return View(bolgeler);
        }
        [Route("/bolgeleriGoruntule")]
        public IActionResult SehirleriGetir(int bolgeId)
        {
            //AJAX get metodundaki data queryString içerisinde gönderiliyor.
            //var x = Request.QueryString;
            
            if(bolgeId >= 1 && bolgeId <= 7)
            {
                return Json(DB.Sehirler().Where(sehir => sehir.BolgeId == bolgeId));
            }
            else
            {
                return BadRequest("1-7 arasında bölge seçimi yapmalısınız!");
            }
            
        }

    }
}
