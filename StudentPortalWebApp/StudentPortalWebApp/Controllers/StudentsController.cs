using Microsoft.AspNetCore.Mvc;
using StudentPortalWebApp.Models;
using StudentPortalWebApp.Services;

namespace StudentPortalWebApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _service;

        public StudentsController(IStudentService service)
        {
            _service = service;
        }

        // =====================================
        // GET: /Students?q=...
        // =====================================
        [HttpGet]
        public async Task<IActionResult> Index(string q = null)
        {
            var students = await _service.SearchAsync(q);
            ViewBag.Query = q ?? "";
            return View(students);
        }

        // =====================================
        // GET: Students/Details/5
        // =====================================
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var student = await _service.GetByIdAsync(id);

            if (student == null)
                return NotFound();

            return View(student);
        }

        // =====================================
        // GET: Students/Create
        // =====================================
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // =====================================
        // POST: Students/Create
        // =====================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (!ModelState.IsValid)
                return View(student);

            student.CreatedAt = DateTime.Now;

            await _service.AddStudentAsync(student);
            return RedirectToAction(nameof(Index));
        }

        // =====================================
        // GET: Students/Edit/5
        // =====================================
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var student = await _service.GetByIdAsync(id);

            if (student == null)
                return NotFound();

            return View(student);
        }

        // =====================================
        // POST: Students/Edit/5
        // =====================================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id != student.StudentId)
                return NotFound();

            if (!ModelState.IsValid)
                return View(student);

            await _service.UpdateStudentAsync(student);
            return RedirectToAction(nameof(Index));
        }

        // =====================================
        // GET: Students/Delete/5
        // =====================================
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _service.GetByIdAsync(id);

            if (student == null)
                return NotFound();

            return View(student);
        }

        // =====================================
        // POST: Students/Delete/5
        // =====================================
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteStudentAsync(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Search(string q)
        {
            var students = await _service.SearchAsync(q);

            var result = students.Select(s => new
            {
                studentId = s.StudentId,
                fullName = s.FullName,
                email = s.Email,
                status = s.Status
            });

            return Json(result);
        }
    }
}