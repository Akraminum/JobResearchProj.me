using JobResearch.Domain.Entities;
using JobResearch.Domain.Entities.Extend;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearch.Infrastructure.Database
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        #region DbSets
        public DbSet<JobSeekerUser> JobSeekers { get; set; }
        public DbSet<CompanyUser> Companies { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Skill> Skills { get; set; }
        #endregion

        public ApplicationContext() { }
        public ApplicationContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Seeding



            #endregion

            #region Configurations
            builder.Entity<Applicant>(entity =>
            {
                entity.HasKey(e => new { e.JobSeekerId, e.JobId });
                entity
                    .HasOne(e => e.JobSeeker)
                    .WithMany(x => x.Applicants)
                    .HasForeignKey(e => e.JobSeekerId)
                    .OnDelete(DeleteBehavior.NoAction);
                entity
                    .HasOne(e => e.Job)
                    .WithMany(x => x.Applicants) 
                    .HasForeignKey(e => e.JobId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            builder.Entity<Job>(entity =>
            {
                entity
                    .HasOne(e => e.JobCategory)
                    .WithMany(x => x.Jobs)
                    .HasForeignKey(e => e.JobCategoryId)
                    .OnDelete(DeleteBehavior.NoAction);
                entity
                    .HasOne(e => e.Company)
                    .WithMany(x => x.Jobs)
                    .HasForeignKey(e => e.CompanyId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

        }
    }
}
