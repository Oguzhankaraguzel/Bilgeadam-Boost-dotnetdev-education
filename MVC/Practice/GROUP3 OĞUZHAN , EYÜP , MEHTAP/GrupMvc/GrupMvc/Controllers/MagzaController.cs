using GrupMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrupMvc.Controllers
{
    public class MagzaController : Controller
    {
        private readonly MagzaContext _db;

        public MagzaController(MagzaContext db)
        {
            _db = db;
        }
        [Route("/Catagory")]
        public IActionResult Catagory()
        {


            return View(_db.Catogories.ToList());
        }

        public IActionResult CatagoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CatagoryAdd(Catogory catogory)
        {
            if (ModelState.IsValid)
            {
                _db.Catogories.Add(catogory);
                _db.SaveChanges();
            }
            return RedirectToAction("Catagory");
        }
        public IActionResult Delete(int Id)
        {
            var selecetedCatagory = _db.Catogories.Find(Id);
            _db.Catogories.Remove(selecetedCatagory);
            _db.SaveChanges();
            return RedirectToAction("Catagory");
        }
        public IActionResult Edit(int Id)
        {

            return View(_db.Catogories.Find(Id));
        }
        [HttpPost]
        public IActionResult Edit(Catogory catogory)
        {
            if (ModelState.IsValid)
            {
                _db.Catogories.Update(catogory);
                _db.SaveChanges();
            }
            return RedirectToAction("Catagory");
        }

    }
}
