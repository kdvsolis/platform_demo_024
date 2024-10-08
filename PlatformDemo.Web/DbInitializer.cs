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
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-9) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-8) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-7) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-6) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-5) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-4) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-3) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-2) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(-1) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(1) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(2) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(3) },
                    new ServicePlan { DateOfPurchase = DateTime.UtcNow.AddDays(4) }
                };

                context.ServicePlans.AddRange(servicePlans);
                context.SaveChanges();
            }

            if (!context.Timesheets.Any())
            {
                var timesheets = new List<Timesheet>
                {
                    new Timesheet { ServicePlanId = 2, StartDateTime = DateTime.UtcNow.AddDays(-10), EndDateTime = DateTime.UtcNow.AddDays(-9), Description = "Initial Setup" },
                    new Timesheet { ServicePlanId = 2, StartDateTime = DateTime.UtcNow.AddDays(-8), EndDateTime = DateTime.UtcNow.AddDays(-7), Description = "Phase 1 Implementation" },
                    new Timesheet { ServicePlanId = 2, StartDateTime = DateTime.UtcNow.AddDays(-5), EndDateTime = DateTime.UtcNow.AddDays(-4), Description = "Follow-up" },
                    new Timesheet { ServicePlanId = 2, StartDateTime = DateTime.UtcNow.AddDays(-3), EndDateTime = DateTime.UtcNow.AddDays(-2), Description = "Final Review" },
                    new Timesheet { ServicePlanId = 3, StartDateTime = DateTime.UtcNow.AddDays(-4), EndDateTime = DateTime.UtcNow.AddDays(-3), Description = "Initial Consultation" },
                    new Timesheet { ServicePlanId = 4, StartDateTime = DateTime.UtcNow.AddDays(-6), EndDateTime = DateTime.UtcNow.AddDays(-5), Description = "Project Kickoff" },
                    new Timesheet { ServicePlanId = 5, StartDateTime = DateTime.UtcNow.AddDays(-2), EndDateTime = DateTime.UtcNow.AddDays(-1), Description = "Mid Project Review" },
                    new Timesheet { ServicePlanId = 6, StartDateTime = DateTime.UtcNow.AddDays(-1), EndDateTime = DateTime.UtcNow, Description = "Final Adjustments" },
                    new Timesheet { ServicePlanId = 7, StartDateTime = DateTime.UtcNow.AddDays(1), EndDateTime = DateTime.UtcNow.AddDays(2), Description = "Documentation" },
                    new Timesheet { ServicePlanId = 8, StartDateTime = DateTime.UtcNow.AddDays(2), EndDateTime = DateTime.UtcNow.AddDays(3), Description = "Training Session" },
                    new Timesheet { ServicePlanId = 9, StartDateTime = DateTime.UtcNow.AddDays(3), EndDateTime = DateTime.UtcNow.AddDays(4), Description = "Launch Preparation" },
                    new Timesheet { ServicePlanId = 10, StartDateTime = DateTime.UtcNow.AddDays(4), EndDateTime = DateTime.UtcNow.AddDays(5), Description = "Post-Launch Support" },
                    new Timesheet { ServicePlanId = 11, StartDateTime = DateTime.UtcNow.AddDays(5), EndDateTime = DateTime.UtcNow.AddDays(6), Description = "Performance Monitoring" },
                    new Timesheet { ServicePlanId = 12, StartDateTime = DateTime.UtcNow.AddDays(6), EndDateTime = DateTime.UtcNow.AddDays(7), Description = "Client Feedback" },
                    new Timesheet { ServicePlanId = 13, StartDateTime = DateTime.UtcNow.AddDays(7), EndDateTime = DateTime.UtcNow.AddDays(8), Description = "Project Closure" },
                    new Timesheet { ServicePlanId = 14, StartDateTime = DateTime.UtcNow.AddDays(8), EndDateTime = DateTime.UtcNow.AddDays(9), Description = "Follow-up Consultation" },
                    new Timesheet { ServicePlanId = 15, StartDateTime = DateTime.UtcNow.AddDays(9), EndDateTime = DateTime.UtcNow.AddDays(10), Description = "Future Planning" }
                };

                context.Timesheets.AddRange(timesheets);
                context.SaveChanges();
            }
        }
    }
}
