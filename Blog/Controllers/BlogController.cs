using Blog.Database;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogContext db;

        public BlogController(BlogContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var posts = db.Posts?.Include(p => p.Comentarios).ToList();
            return View(posts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                db.Posts?.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(post);
        }

        private Post? GetPostById(int id)
        {
            return db.Posts?.Include(p => p.Comentarios).FirstOrDefault(p => p.Id == id);
        }

        public IActionResult Edit(int id)
        {
            var post = GetPostById(id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var post = db.Posts?.Find(id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var post = db.Posts?.Find(id);
            if (post != null)
            {
                db.Posts?.Remove(post);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var post = GetPostById(id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }
    }
}
