using Educational_Center.Data;
using Educational_Center.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Educational_Center.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeacherController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Teachers
        public IActionResult Index()
        {
            var teachers = _context.Teachers.ToList();
            return View(teachers);
        }

        // GET: Teachers/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = _context.Teachers.FirstOrDefault(t => t.TeacherId == id);

            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // GET: Teachers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Teachers.Add(teacher);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        // GET: Teachers/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = _context.Teachers.Find(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // POST: Teachers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Teacher teacher)
        {
            if (id != teacher.TeacherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Entry(teacher).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherExists(teacher.TeacherId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(teacher);
        }

        private bool TeacherExists(int id)
        {
            return _context.Teachers.Any(e => e.TeacherId == id);
        }

        // GET: Teachers/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = _context.Teachers.FirstOrDefault(t => t.TeacherId == id);

            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var teacher = _context.Teachers.Find(id);
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
