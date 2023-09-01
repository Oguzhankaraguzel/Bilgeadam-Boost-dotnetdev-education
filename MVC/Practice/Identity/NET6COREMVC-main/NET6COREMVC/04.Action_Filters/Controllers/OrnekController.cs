using _04.Action_Filters.Filters;
using _04.Action_Filters.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _04.Action_Filters.Controllers
{
    [CustomActionFilter("OrnekController",-2)]
    [ResponseHeader("ControllerName","Atakan Bey")]
    public class OrnekController : Controller
    {
        [CustomActionFilter("ORNEK-Index",-1)]
        [ResponseHeader("ControllerName", "Gokcehan Bey")]
        public IActionResult Index(string bilgi)
        {
            Console.WriteLine("Aksiyondayız");
            return Ok(bilgi ?? "BİLGİ YOK");
        }

        public IActionResult Index2(string fullname)
        {
            return Ok(fullname);
        }

        [ResponseHeader("ActionName", "Ekle")]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Category cat)
        {
            return View();
        }

    }
}
