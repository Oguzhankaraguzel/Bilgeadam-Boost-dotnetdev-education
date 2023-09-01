using _02.Uygulama01.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02.Uygulama01.Controllers
{

    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View(Product.Products);
        }

        //....../Product/Index
        public IActionResult Index1()
        {
            //Product.Products.Add(new Product(4, "Kiraz", 400, "Meyve"));
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }

    }
}
