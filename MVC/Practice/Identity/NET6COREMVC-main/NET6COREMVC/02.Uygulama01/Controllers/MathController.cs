
using _02.Uygulama01.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02.Uygulama01.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Sqrt(int sayi)
        {
            return View("OperasyonSonucu", new Islem() { Sayi = sayi, Sonuc = Math.Sqrt(sayi) });
        }

        public IActionResult IslemYap()
        {
            return View();
        }
    }
}
