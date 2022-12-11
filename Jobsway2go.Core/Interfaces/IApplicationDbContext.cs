using Jobsway2go.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<ForgotPasswordModel> ForgotPassword { get; set; }
        DbSet<ResetPasswordModel> ResetPassword { get; set; }

    }
}
