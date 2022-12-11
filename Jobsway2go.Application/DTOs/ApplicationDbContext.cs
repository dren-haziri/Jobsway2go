using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Application.DTOs
{
    public class ApplicationDbContext: DbContext, IApplicationDbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ForgotPasswordModel> ForgotPassword { get; set; }
        public DbSet<ResetPasswordModel> ResetPassword { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
