using Microsoft.AspNetCore.Mvc;
using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;

namespace Jobsway2go.WebUI.Controllers
{
    public class CollectionController : Controller
    {
        private readonly ICollectionService _collectionService;

        public CollectionController(ICollectionService collectionService)
        {
            _collectionService = collectionService;
        }

        public IActionResult Index()
        {
            var collections = _collectionService.GetAll();
            return View(collections);
        }
        public IActionResult Details(int id)
        {
            var collections = _collectionService.GetById(id);
            return View(collections);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Collection collection)
        {
            if (ModelState.IsValid)
            {
                _collectionService.Add(collection);
                return RedirectToAction("Index");
            }
            return View(collection);
        }

        public IActionResult Update(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var collection = _collectionService.GetById(id);
            if (collection == null)
            {
                return NotFound();
            }
            return View(collection);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Collection collection)
        {
            if (ModelState.IsValid)
            {
                _collectionService.Update(collection);
                return RedirectToAction("Index");
            }
            return View(collection);
        }

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var collection = _collectionService.GetById(id);
            if (collection == null)
            {
                return NotFound();
            }
            return View(collection);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Collection collection)
        {

            _collectionService.Remove(collection);
            return RedirectToAction("Index");
        }


    }
}
