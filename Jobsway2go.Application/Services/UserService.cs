using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Application.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;

        private readonly RoleManager<ApplicationUser> _roleManager;

        public UserService(UserManager<ApplicationUser> userManager, 
                            SignInManager<ApplicationUser> signInManager, 
                            RoleManager<ApplicationUser> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public bool SignIn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SignOut { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Register { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EmailVerification { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EmailConfirmed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EditProfile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool VerifyUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
