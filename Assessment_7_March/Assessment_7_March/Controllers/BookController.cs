using Assessment_7_March.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assessment_7_March.Models;
namespace Assessment_7_March.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _repo;

        public BookController(IBookRepository repo)
        {
            _repo = repo;
        }

        // GET: BookController
        public ActionResult Index()
        {
            return View(_repo.GetAllBooks());
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetBookById(id));
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            if (_repo.AddBook(book))
                return RedirectToAction("Index");

            return View(book);
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = _repo.GetBookById(id);
            return View(book);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (_repo.UpdateBook(book))
                return RedirectToAction("Index");

            return View(book);
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = _repo.GetBookById(id);
            return View(book);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Book book)
        {
            _repo.DeleteBook(id);
            return RedirectToAction("Index");
        }
    }
}
