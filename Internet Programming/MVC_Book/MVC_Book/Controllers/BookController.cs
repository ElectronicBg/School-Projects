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
        public IActionResult Search(string searchTitle)
        {
            var allBooks = _context.Books.ToList();

            var searchResult = allBooks.Where(book => book.Title.Contains(searchTitle)).ToList();

            return View(searchResult);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var book = _context.Books.Where(x => x.Id == id).SingleOrDefault();
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
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
        public IActionResult Delete(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            _context.Books.Remove(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

