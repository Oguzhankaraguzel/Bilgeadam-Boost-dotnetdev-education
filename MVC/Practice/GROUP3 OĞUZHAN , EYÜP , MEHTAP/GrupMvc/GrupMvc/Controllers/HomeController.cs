using GrupMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GrupMvc.Controllers
{
    public class HomeController : Controller
    {

        private readonly MagzaContext _db;

        public HomeController(MagzaContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Product> myList = new List<Product>();
            List<Catogory> oguzhanList = new List<Catogory>();
            ViewData["Catogory"] = new SelectList(_db.Catogories, "Id", "Name");
            myList = _db.Products.ToList();
            oguzhanList = _db.Catogories.ToList();
            var tuple = (myList, oguzhanList);
            return View(tuple);
        }
      



    }
}