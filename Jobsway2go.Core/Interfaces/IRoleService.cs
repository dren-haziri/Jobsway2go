using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Jobsway2go.Core.Interfaces
{
    public interface IRoleService : IRepository<Role>
    {
        IQueryable<IdentityRole> GetRoles();
    }
}