using Jobsway2go.Application.Services;
using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jobsway2go.WebUI.Controllers
{
    public class UserController : Controller
    {
        IUserService _userService;
        public IActionResult Index()
        {
            return View();
        }
        public bool RegisterUser(ApplicationUser user)
        {
            return _userService.Register(user);
        }
    }
}
