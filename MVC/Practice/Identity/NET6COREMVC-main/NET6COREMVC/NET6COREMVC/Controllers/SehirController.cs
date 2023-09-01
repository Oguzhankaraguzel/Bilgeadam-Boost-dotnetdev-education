using Microsoft.AspNetCore.Mvc;

namespace NET6COREMVC.Controllers
{
    public class SehirController : Controller
    {
        public IActionResult Sehirler()
        {
            return View("Index");
        }
        //sehir/sehirlerveulkeler
        public IActionResult SehirlerVeUlkeler()
        {
            ViewData["Title"] = "Şehirler ve ülkeler controller";
            return View();
        }
    }
}
