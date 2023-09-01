using _01.NETCORE6MVCGiris.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01.NETCORE6MVCGiris.Controllers
{
    public class InsanController : Controller
    {
        private static List<Insan> insanlar = new()
            {
                new Insan(1,"Fatih Kaan Açıkgöz", 1994),
                new Insan(2,"Gökçehan Gücük", 1997),
                new Insan(3,"Oğuz Kağan Ünal", 1998)
            };
        public IActionResult Index()
        {
            return View(insanlar);
        }

        public IActionResult Detay(int id)
        {
            /*var detayKisi = insanlar.Where(insan => insan.Id == id).FirstOrDefault();
            return View(detayKisi);*/
            return View(insanlar.Where(insan => insan.Id == id).FirstOrDefault());
        }

        public IActionResult Sil(int id)
        {
            /*var detayKisi = insanlar.Where(insan => insan.Id == id).FirstOrDefault();
            return View(detayKisi);*/
            return View(insanlar.Remove(insanlar.Where(insan => insan.Id == id).FirstOrDefault()));
        }

        public IActionResult Ekle(Insan insan, Takim takim)
        {
            
            return View();
        }

    }
}
