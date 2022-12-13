using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;

namespace Jobsway2go.Application.Services
{

    public class UserService : IUserService
    {
        //Injection
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public bool SignIn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SignOut { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public bool Register { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task<bool> RegisterUser(string email)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                IdentityResult result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                    return true;
            }
            else
                return false;
            
            return false;
        }

        public bool EmailVerification { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EmailConfirmed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EditProfile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool VerifyUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
      
        public async Task<bool> DeleteUser(string userId)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return true;
            }
            else
                return false;
            //Nuk jomm tu dit qa me bo return a naj action to Index ??
            return false;
        }

        public bool Register(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public void Add(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<ApplicationUser> entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ApplicationUser> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<ApplicationUser> entity)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> Find(Expression<Func<ApplicationUser, bool>> predicate, params Expression<Func<ApplicationUser, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser FindOne(Expression<Func<ApplicationUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}