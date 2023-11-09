using Microsoft.AspNetCore.Mvc;
using MVC_Book.Data;
using MVC_Book.Models;

namespace MVC_Book.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BookController(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var data = _context.Books.Where
                (x => x.Id == id).SingleOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Update(int id, Book book)
        {
            var bookData = _context.Books.
                FirstOrDefault(x => x.Id == id);

            if (bookData != null)
            {
                bookData.Title = book.Title;
                bookData.Year = book.Year;
                bookData.Author = book.Author;
                bookData.CoverImage = book.CoverImage;
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
