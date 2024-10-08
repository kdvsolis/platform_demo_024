﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformDemo.Data.Models
{
    public class ServicePlan
    {
        public int Id { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public ICollection<Timesheet> Timesheets { get; set; } = new List<Timesheet>();
    }
}
