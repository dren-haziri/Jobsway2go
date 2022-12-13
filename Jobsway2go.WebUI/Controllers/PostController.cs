using Jobsway2go.Application.Services;
using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jobsway2go.WebUI.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        public IActionResult Index()
        {
            var posts = _postService.GetAll();
            return View(posts);
        }
        public IActionResult Details(int id)
        {
            var post = _postService.GetById(id);
            return View(post);
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
                _postService.Add(post);
                return RedirectToAction("Index");
            }
            return View(post);
        }

        public IActionResult Update(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var post = _postService.GetById(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Post post)
        {
            if (ModelState.IsValid)
            {
                _postService.Update(post);
                return RedirectToAction("Index");
            }
            return View(post);
        }

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var post = _postService.GetById(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Post post)
        {

            _postService.Remove(post);
            return RedirectToAction("Index");
        }
    }
}
