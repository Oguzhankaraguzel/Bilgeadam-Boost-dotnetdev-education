using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace NET6COREMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            //Response.Headers["date"] = (new DateTime(2000, 5, 16)).ToString();
            return View();
        }
        // Home/Yaz1
        // home/yaz1
        public string Yaz1()
        {
            return "İlk Yazı!";
        }

        public string Yaz2()
        {
            return "<h1>İlk Yazı!</h1>";
        }

        public ContentResult Yaz3()
        {
            return Content("<h1>İlk Yazı!</h1>", "text/html", Encoding.UTF8);
        }
        //Home/Yaz4
        public IActionResult Yaz4()
        {
            return Content("<h1>İlk Yazı!</h1>", "text/html", Encoding.UTF8);
        }

        //Home/Yaz5
        public IActionResult Yaz5()
        {
            return Ok("başarılı");
        }
        //Home/Yaz6
        public string Yaz6()
        {
            //var cevap = NotFound("içerik yok!");
            //cevap.StatusCode = 404;

            Response.StatusCode = 404;
            return "İçerik yok!";
        }

        //Home/Yaz7
        public IActionResult Yaz7()
        {
            if (Request.Headers["bilgi"].ToString() != "")
            {
                return Ok(Request.Headers["bilgi"]);
            }
            else
            {
                Response.Headers["cevap"] = "bilgi vermedin ki sana bilgini soyleyeyim!";
                return NotFound("İçerik yok!");
            }
        }
        [HttpPost]
        public IActionResult Yaz8()
        {
            return Ok("HTTP POST REQUEST GELDİ VE CEVAPLANDI!");
        }
        // Home/BilgiVer
        public IActionResult BilgiVer()
        {
            // ~ ana(root) dizin
            // ./ aynı dizin
            // ../ bir önceki dizin
            //return View("~/Views/Cart/Curt.cshtml");
            //return View("Curt2");
            return View();
        }
    }
}
