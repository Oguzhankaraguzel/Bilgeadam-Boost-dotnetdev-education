using _03.ModelBinding.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace _03.ModelBinding.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new()
            {
                new User(1,"fka123","asd123","fk","a"),
                new User(2,"asd123","asdsa12312","asdsa123","aasdas"),
                new User(3,"fkasdaa123","asd12asdas3","fkasdas","aasdas")
            };

        //https://localhost:7280/User/Index
        [Route("/userAnasayfa")]
        public IActionResult Index2()
        {
            //return Ok("Başarıyla kaydedildi!");
            return View("Index2","Başarıyla kaydedildi!");
        }

        public IActionResult BilgiVer()
        {
            return View();
        }

        [Route("/logIn")]
        public IActionResult SignIn(string username, string password)
        {
            return View();
        }
        /*[HttpPost]
        [Route("/logIn")]
        //[Route("/girisYap")]
        public IActionResult SignIn(IFormCollection form)
        {
            var x1 = form["username"].ToString();
            var x2 = form["password"];
            return View();
        }*/
        [HttpPost]
        [Route("/logIn")]
        public IActionResult SignIn(User user)
        {

            //return View();
            //ViewData["test"] = "test";
            TempData["msg"] = "success";
            return RedirectToAction("Index","Home");
        }


        //https://localhost:7280/ - www.mehmetmustafa.com
        //https://localhost:7280/User/Goruntule
        [HttpGet]
        //defaultta parametreler queryden (QUERY PARAMS) gelir
        public IActionResult Goruntule([FromBody] BasicUser user)
        {
            string bodyIsimSoyad = $"'{user.isim} {user.soyad}' başarıyla görüntülendi!";
            string headerIsimSoyad = Request.Headers["isim"] + " " + Request.Headers["soyad"];
            string queryIsimSoyad = Request.Query["isim"] + " " + Request.Query["soyad"];

            string msg = $"BODY: {bodyIsimSoyad} HEADER: {headerIsimSoyad} QUERY: {queryIsimSoyad}";
            return Ok(msg);
        }

        [Route("KullanicilariGoruntule")]
        public IActionResult Index()
        {
            
            return View(users);
        }
        
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            users.Add(user);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
           
            return View(users.Where(user => user.Id == id).First());
        }
        [HttpPost]
        public IActionResult Edit(int id, User user)
        {
            users.Remove(users.Where(user => user.Id == id).First());
            users.Add(user);
            users = users.OrderBy(user => user.Id).ToList();
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            
            return View(users.Where(user => user.Id == id).First());
        }

        public IActionResult Delete(int id)
        {
            
            return View(users.Where(user => user.Id == id).First());
        }
        [HttpPost]
        public IActionResult Delete(int id, User user)
        {
            users.Remove(users.Where(user => user.Id == id).First());
            return RedirectToAction("Index");
        }

    }
}
