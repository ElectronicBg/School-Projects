using Microsoft.AspNetCore.Mvc;
using MVC__Fluffy_Duffy_Munchkin_Cats.Data;
using MVC__Fluffy_Duffy_Munchkin_Cats.Models;

namespace MVC__Fluffy_Duffy_Munchkin_Cats.Controllers
{
    public class CatController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CatController(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var cats=_context.Cats.ToList();
            return View(cats);
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Cat cat)
        {
            _context.Cats.Add(cat);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var data = _context.Cats.Where
                (x => x.ID == id).SingleOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Update(int id, Cat cat)
        {
            var catData = _context.Cats.
                FirstOrDefault(x => x.ID == id);

            if (catData != null)
            {
                catData.Name = cat.Name;
                catData.Age = cat.Age;
                catData.Breed = cat.Breed;
                catData.Img_Url = cat.Img_Url;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
