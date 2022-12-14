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
        DbSet<Post> Posts { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<Job> Jobs { get; set; }
        DbSet<JobCategory> JobCategories { get; set; }
        DbSet<Notification> Notifications { get; set; }
        DbSet<Section> Sections { get; set; }
        DbSet<Collection> Collections { get; set; }
        DbSet<Role> Roles { get; set; }
        Task<int> SaveChangesAsync();
    }
}