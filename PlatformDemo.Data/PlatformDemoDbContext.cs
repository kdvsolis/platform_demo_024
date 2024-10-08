using Microsoft.EntityFrameworkCore;
using PlatformDemo.Data.Models;
using System.Collections.Generic;

namespace PlatformDemo.Data
{
    public class PlatformDemoDbContext : DbContext
    {
        public PlatformDemoDbContext(DbContextOptions<PlatformDemoDbContext> options)
            : base(options) { }

        public DbSet<ServicePlan> ServicePlans { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServicePlan>()
                .HasMany(sp => sp.Timesheets)
                .WithOne(ts => ts.ServicePlan)
                .HasForeignKey(ts => ts.ServicePlanId);
        }
    }
}
