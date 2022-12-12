﻿using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jobsway2go.WebUI.Controllers
{
    public class GroupController : Controller
    {
        private readonly IGroupService _groupService;
        private readonly IApplicationDbContext _context;    
        public GroupController (IApplicationDbContext ctx, IGroupService groupService)
        {
            _groupService = groupService;
            _context = ctx;
        }

        public IActionResult Index()
        {
            var groups = _groupService.GetAll();
            return View(groups);
        }
        public IActionResult Details(int id)
        {
            var group = _groupService.GetById(id);
            return View(group);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Group group)
        {
            if (ModelState.IsValid)
            {
                _groupService.Add(group);
                _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(group);
        }

        public IActionResult Update(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var group = _groupService.GetById(id);
            if (group == null)
            {
                return NotFound();
            }
            return View(group);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Group group)
        {
            if (ModelState.IsValid)
            {
                _groupService.Update(group);
                _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(group);
        }

        public IActionResult Delete(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }

            var group = _groupService.GetById(id);
            if(group == null)
            {
                return NotFound();
            }
            return View(group);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete (Group group)
        {

            _groupService.Remove(group);
            _context.SaveChangesAsync();
            return RedirectToAction("Index");   
        }


    }
}
