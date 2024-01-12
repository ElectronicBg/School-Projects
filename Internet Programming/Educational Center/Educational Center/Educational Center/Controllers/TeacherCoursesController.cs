using Educational_Center.Data;
using Educational_Center.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Educational_Center.Controllers
{
    public class TeacherCourseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeacherCourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TeacherCourses
        public IActionResult Index()
        {
            var teacherCourses = _context.TeacherCourses
                .Include(tc => tc.Teacher)
                .Include(tc => tc.Course)
                .ToList();
            return View(teacherCourses);
        }

        // GET: TeacherCourses/Create
        public IActionResult Create()
        {
            ViewBag.Teachers = _context.Teachers.ToList();
            ViewBag.Courses = _context.Courses.ToList();
            return View();
        }

        // POST: TeacherCourses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TeacherCourse teacherCourse)
        {
            if (ModelState.IsValid)
            {
                _context.TeacherCourses.Add(teacherCourse);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Teachers = _context.Teachers.ToList();
            ViewBag.Courses = _context.Courses.ToList();
            return View(teacherCourse);
        }

        // GET: TeacherCourses/Delete/5
        public IActionResult Delete(int? teacherId, int? courseId)
        {
            if (teacherId == null || courseId == null)
            {
                return NotFound();
            }

            var teacherCourse = _context.TeacherCourses
                .Include(tc => tc.Teacher)
                .Include(tc => tc.Course)
                .FirstOrDefault(tc => tc.TeacherId == teacherId && tc.CourseId == courseId);

            if (teacherCourse == null)
            {
                return NotFound();
            }

            return View(teacherCourse);
        }

        // POST: TeacherCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int teacherId, int courseId)
        {
            var teacherCourse = _context.TeacherCourses
                .FirstOrDefault(tc => tc.TeacherId == teacherId && tc.CourseId == courseId);

            if (teacherCourse != null)
            {
                _context.TeacherCourses.Remove(teacherCourse);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
