using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace Jobsway2go.Application.Services
{

    public class UserService : IUserService
    {
        //Injection
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserService( UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task<bool> VerifyUser(string name, string password)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(name);
            if (user != null)
            {
                await _userManager.CheckPasswordAsync(user, password);
                return true;
            }
            return false;

        }


        public async Task<IdentityResult> DeleteUser(string userId)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);

                return result;
                            
            }
           return IdentityResult.Failed();
        }
        //duhet me e perfundu

        public async Task<IdentityResult> Register(RegisterUser appuser)
        {
            ApplicationUser user = new ApplicationUser
            {
                Email = appuser.Email,
                FirstName = appuser.FirstName,
                LastName = appuser.FirstName,
                UserName = appuser.UserName
            };
            IdentityResult result = await _userManager.CreateAsync(user, appuser.Password);

            if (result.Succeeded)
            {
                var userRole = _roleManager.FindByNameAsync("User").Result;
                if (userRole != null)
                {
                    await _userManager.AddToRoleAsync(user, userRole.Name);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                }

            }
            return result;

        }

        public async Task<IdentityResult> RegisterBusiness(RegisterBusiness appuser)
        {
            ApplicationUser user = new ApplicationUser
            {
                Email = appuser.Email,
                FirstName = appuser.FirstName,
                LastName = appuser.FirstName,
                UserName = appuser.UserName,
                CompanyName = appuser.CompanyName,
                CompanyArea = appuser.CompanyArea
            };
            IdentityResult result = await _userManager.CreateAsync(user, appuser.Password);

            if (result.Succeeded)
            {
                var userRole = _roleManager.FindByNameAsync("Business").Result;
                if (userRole != null)
                {
                    await _userManager.AddToRoleAsync(user, userRole.Name);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                }

            }
            return result;

        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return _userManager.Users.ToList();
        }




        public bool SignIn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SignOut { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EmailVerification { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EmailConfirmed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EditProfile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool VerifyUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
      
      

        
      
    }
}