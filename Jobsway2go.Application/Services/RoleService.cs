using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Application.Services
{
    public class RoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IApplicationDbContext _dbContext;

        public RoleService(RoleManager<IdentityRole> roleManager, IApplicationDbContext dbContext)
        {
            _roleManager = roleManager;
            _dbContext = dbContext;
        }
        public async Task<IdentityResult> CreateRole(Role role)
        {
            var result = await _roleManager.CreateAsync(role);

            var roles = _dbContext.Roles;

            roles.Add(role);

            await _dbContext.SaveChangesAsync();

            return result;
        }

        public async Task<IdentityResult> DeleteRole(Role role)
        {
            var result = await _roleManager.DeleteAsync(role);

            var roles = _dbContext.Roles;

            roles.Remove(role);

            await _dbContext.SaveChangesAsync();

            return result;
        }

        public async Task<bool> RoleExists(string roleName)
        {
            return await _roleManager.RoleExistsAsync(roleName);
        }
    }
}