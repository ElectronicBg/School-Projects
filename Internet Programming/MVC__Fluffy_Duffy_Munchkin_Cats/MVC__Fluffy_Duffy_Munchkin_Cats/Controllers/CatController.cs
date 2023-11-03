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
    }
}
