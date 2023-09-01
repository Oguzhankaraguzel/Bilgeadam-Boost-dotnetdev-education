using _07.Routing.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07.Routing.Controllers
{
    [Route("[controller]/[action]")]
    public class SehirlerController : Controller
    {
        private List<Sehir> sehirler = new()
        {
            new Sehir(){PlakaKodu = 34, Ad = "İstanbul", Nufus = 16000000},
            new Sehir(){PlakaKodu = 6, Ad = "Ankara", Nufus = 6000000},
            new Sehir(){PlakaKodu = 4, Ad = "Ağrı", Nufus = 540000}
        };
        public IActionResult Index()
        {
            return View(sehirler);
        }
        [Route("ilGoster/{plakaKodu:int}/{test}")]
        [Route("{plakaKodu:int}")]
        public IActionResult SehirBilgiVer(int plakaKodu, string test, string cevap)
        {
            var x = Request.QueryString;
            return View(sehirler.Where(sehir => sehir.PlakaKodu == plakaKodu).FirstOrDefault());
        }

        [Route("{sehirAd}")]
        public IActionResult SehirBilgiVer(string sehirAd)
        {
            
            return View(sehirler.Where(sehir => string.Equals(sehir.Ad, sehirAd,StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault());
        }

    }
}
