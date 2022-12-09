using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;

namespace Jobsway2go.WebUI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<bool> Activate(string userId)
        {
            ApplicationUser user = _userManager.FindByIdAsync(userId);
            user.await();
            var result = user.Result;
            if (result)
            {
                user.isActive = true;
                return true;
            }
            return false;
        }
        public async Task<bool> Deactivate(string userId)
        {
            ApplicationUser user = _userManager.FindByIdAsync(userId);
            user.await();
            var result = user.Result;
            if (result)
            {
                user.isActive = false;
                return true;
            }
            return false;
        }
    }
}
