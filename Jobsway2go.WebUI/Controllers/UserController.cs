using Microsoft.AspNetCore.Mvc;
using Jobsway2go.Application.Services;
using Jobsway2go.Application.DTOs;
using Jobsway2go.Application.Services;
using Jobsway2go.Core.Interfaces;

namespace Jobsway2go.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        

        [HttpPost]
        public async Task<IActionResult> SignInUser(LoginModel loginModel)
        {

            if (ModelState.IsValid)
            {
                var result = await userService.SignInUser(loginModel.Email,loginModel.Password);
                if (result.Succeeded)
                {
                    
                    return RedirectToAction("Index", "Home");
                }
                //return RedirectToAction("LogIn");
            }
            return RedirectToAction("LogIn");
        }
    }
}
