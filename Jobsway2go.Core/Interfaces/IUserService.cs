using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Jobsway2go.Core.Interfaces
{
    public interface IUserService
    {
         bool SignIn { get; set; }
         bool SignOut { get; set; }

        Task<IdentityResult> Register(RegisterUser user);
        Task<IdentityResult> RegisterBusiness(RegisterBusiness userB);
        IEnumerable<ApplicationUser> GetAll();
        bool  EmailVerification { get;set; }
        bool  EmailConfirmed { get; set; }

        bool  EditProfile { get; set; }
        Task<bool> VerifyUser(string name, string password); 

        Task<IdentityResult> DeleteUser(string userId);

        Task<SignInResult> SignInUser(SignInUser signIn);
        Task SignOutUser();
    }
}
