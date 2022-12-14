using Jobsway2go.Core.Interfaces;
using Jobsway2go.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Infrastructure.Common
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CollectionPost>()
                .HasKey(t => new { t.PostId, t.CollectionId });

            modelBuilder.Entity<CollectionPost>()
                .HasOne(cp => cp.post)
                .WithMany(p => p.CollectionPost)
                .HasForeignKey(cp => cp.PostId);

            modelBuilder.Entity<CollectionPost>()
                .HasOne(cp => cp.collection)
                .WithMany(c => c.CollectionPost)
                .HasForeignKey(cp => cp.CollectionId);


            modelBuilder.Entity<CollectionJob>()
                .HasKey(t => new { t.JobId, t.CollectionId });

            modelBuilder.Entity<CollectionJob>()
                .HasOne(cp => cp.job)
                .WithMany(p => p.CollectionJob)
                .HasForeignKey(cp => cp.JobId);

            modelBuilder.Entity<CollectionJob>()
                .HasOne(cp => cp.collection)
                .WithMany(c => c.CollectionJob)
                .HasForeignKey(cp => cp.CollectionId);

            

        }



        public DbSet<Post> Posts { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<CollectionPost> CollectionPosts { get; set; }
        public DbSet<CollectionJob> CollectionJob { get; set; }

        public DbSet<Role> Roles { get; set; }
        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }


    }
}