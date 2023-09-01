using Microsoft.AspNetCore.Mvc;

namespace _07.Routing.Controllers
{
    //[Route("[action]")]
    public class RastgeleController : Controller
    {
        // localhost:portNo/sayiVer
        // 1-49 arasında bir sayı View'de yazdırılacak!

        //"Sayı Üret" menüye eklenecek ve tıklandığında üretilen sayı
        //görüntülenecektir.
        // VIEW => Üretilen Sayı: 45

        [Route("/sayiVer")]
        public IActionResult SayiUret()
        {
            return View((new Random()).Next(1, 50));
        }

        // Client (İstemci)
        // localhost:portNo/kazananNumaralar
        // url aracılığıyla hizmet alacak.

        //6 tane 1-49 arasında sayı üretilecek.
        //Kazanan numaralar sayfada gösterilecek.

        // VIEW =>
        // Kazanan Numaralar: 1-45-3-6-11-35
        [Route("/kazananNumaralar")]
        public IActionResult KazananNumaralar()
        {
            List<int> toplar = new();
            List<int> cekilenSayilar = new();
            toplar.AddRange(Enumerable.Range(1, 49));

            for(int i = 0; i < 6; i++)
            {
                int rastgeleIndex = (new Random()).Next(0, toplar.Count);
                cekilenSayilar.Add(toplar[rastgeleIndex]);
                toplar.RemoveAt(rastgeleIndex);
            }
            return View(cekilenSayilar);
        }
    }
}
