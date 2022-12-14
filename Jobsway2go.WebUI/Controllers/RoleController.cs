using Jobsway2go.Application.Services;
using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Jobsway2go.WebUI.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        public IActionResult Index()
        {
            var roles = _roleService.GetRoles();
            return View(roles);
        }

        [HttpPost]
        public async Task<ActionResult<IdentityResult>> CreateRole(Role role)
        {
            var result = await _roleService.CreateRole(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete]
        public async Task<ActionResult<IdentityResult>> DeleteRole(Role role)
        {
            var result = await _roleService.DeleteRole(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<ActionResult<bool>> RoleExists(string roleName)
        {
            var exists = await _roleService.RoleExists(roleName);
            return View(exists);
        }
    }
}