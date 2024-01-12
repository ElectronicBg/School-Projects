using Educational_Center.Data;
using Educational_Center.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Educational_Center.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Courses
        public IActionResult Index()
        {
            var courses = _context.Courses.Include(c => c.Students).Include(c => c.TeacherCourses).ToList();
            return View(courses);
        }

        // GET: Courses/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = _context.Courses.Include(c => c.Students).Include(c => c.TeacherCourses).FirstOrDefault(c => c.CourseId == id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(course);
        }

        // GET: Courses/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = _context.Courses.Find(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Course course)
        {
            if (id != course.CourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Entry(course).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.CourseId))
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

            return View(course);
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.CourseId == id);
        }

        // GET: Courses/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = _context.Courses.Include(c => c.Students).Include(c => c.TeacherCourses).FirstOrDefault(c => c.CourseId == id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var course = _context.Courses.Find(id);
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
