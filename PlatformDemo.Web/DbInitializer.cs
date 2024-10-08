using PlatformDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlatformDemo.Data
{
    public static class DbInitializer
    {
        public static void Seed(PlatformDemoDbContext context)
        {
            if (!context.ServicePlans.Any())
            {
                var servicePlans = new List<ServicePlan>
                {
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-10) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-5) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-3) },
                };

                context.ServicePlans.AddRange(servicePlans);
                context.SaveChanges();
            }

            if (!context.Timesheets.Any())
            {
                var timesheets = new List<Timesheet>
                {
                    new Timesheet { ServicePlanId = 1, StartDateTime = DateTime.UtcNow.AddDays(-10), EndDateTime = DateTime.UtcNow.AddDays(-9), Description = "Initial Setup" },
                    new Timesheet { ServicePlanId = 2, StartDateTime = DateTime.UtcNow.AddDays(-5), EndDateTime = DateTime.UtcNow.AddDays(-4), Description = "Follow-up" },
                    // Add more timesheets here
                };

                context.Timesheets.AddRange(timesheets);
                context.SaveChanges();
            }
        }
    }
}
