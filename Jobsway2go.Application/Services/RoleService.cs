using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IApplicationDbContext _dbContext;

        public RoleService(RoleManager<IdentityRole> roleManager, IApplicationDbContext dbContext)
        {
            _roleManager = roleManager;
            _dbContext = dbContext;
        }

        public void Add(Role entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Role> entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> CreateRole(Role role)
        {
            var result = await _roleManager.CreateAsync(role);

            _dbContext.Roles.Add(role);

            await _dbContext.SaveChangesAsync();

            return result;
        }

        public async Task<IdentityResult> DeleteRole(Role role)
        {
            var result = await _roleManager.DeleteAsync(role);

            _dbContext.Roles.Remove(role);

            await _dbContext.SaveChangesAsync();

            return result;
        }

        public IEnumerable<Role> Find(Expression<Func<Role, bool>> predicate, params Expression<Func<Role, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Role FindOne(Expression<Func<Role, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public Role GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Role entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Role> entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RoleExists(string roleName)
        {
            return await _roleManager.RoleExistsAsync(roleName);
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Role entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<Role> entity)
        {
            throw new NotImplementedException();
        }
    }
}