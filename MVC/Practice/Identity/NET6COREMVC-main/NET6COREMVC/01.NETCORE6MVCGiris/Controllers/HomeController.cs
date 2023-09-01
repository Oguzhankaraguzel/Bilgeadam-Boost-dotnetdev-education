using _01.NETCORE6MVCGiris.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _01.NETCORE6MVCGiris.Controllers
{
    public class HomeController : Controller
    {
        //ViewData ve ViewBag kullanarak veri aktarımı
        //Genel geçer bilgileri view'e iletmek için kullanılan veri taşıyıcıları
        public IActionResult Index1()
        {

            ViewData["Isim"] = "Fatih Kaan";
            ViewData["SoyIsim"] = "Açıkgöz";
            ViewBag.adSoyad = "Fatih Kaan Açıkgöz";

            ViewData["DogumYili"] = 1994;
            ViewBag.DogumYili = 1990;

            ViewData["Insan1"] = new Insan() { AdiSoyadi = "Gökçehan Gücük", DogumYili = 1997 };
            ViewBag.Insan2 = new Insan() { AdiSoyadi = "Fatih Kaan Açıkgöz", DogumYili = 1994 };


            ViewData["liste1"] = new List<string>() { "L1item1", "L1item2", "L1item3" };
            ViewBag.liste2 = new List<string>() { "L2item1", "L2item2", "L2item3" };
            return View("Index");
        }

        //URL aracılığıyla veri alımı
        //route bilgisi kullanarak
        //query bilgisi kullanarak
        public IActionResult Index2(string id, string ad, string soyad)
        {

            ViewData["KullaniciId"] = id;
            ViewData["AdiSoyadi1"] = ad + " " + soyad;
            //var x = Request.Query["isim"];
            //var y = Request.Query["soyIsim"];
            ViewData["AdiSoyadi2"] = Request.Query["isim"].ToString() + " " + Request.Query["soyIsim"].ToString();
            return View();
        }

        public IActionResult Index3()
        {

            //return View(20);
            //return View("Index3", "Fatih Kaan Açıkgöz");

            return View(new Insan("Fatih Kaan Açıkgöz", 1994));
        }

        public IActionResult KisiBilgisiGoster()
        {
            return View("Index3",new Insan("Fatih Kaan Açıkgöz", 1994));
        }


        public IActionResult Index4()
        {
            List<Insan> insanlar = new()
            {
                new Insan("Fatih Kaan Açıkgöz", 1994),
                new Insan("Gökçehan Gücük", 1997),
                new Insan("Oğuz Kağan Ünal", 1998)
            };
            return View(insanlar);
        }

        public IActionResult Index5()
        {
            List<Insan> insanlar = new()
            {
                new Insan("Fatih Kaan Açıkgöz", 1994),
                new Insan("Gökçehan Gücük", 1997),
                new Insan("Oğuz Kağan Ünal", 1998)
            };

            List<Takim> takimlar = new()
            {
                new Takim("Galatasaray",1905),
                new Takim("Fenerbahçe",1907),
                new Takim("Beşiktaş",1903)
            };

            InsanTakimViewModel itvm = new ();
            itvm.Insanlar = insanlar;
            itvm.Takimlar = takimlar;

            return View(itvm);
        }

    }
}