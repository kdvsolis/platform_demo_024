using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlatformDemo.Data;
using PlatformDemo.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ServicePlansModel : PageModel
{
    private readonly PlatformDemoDbContext _context;

    public ServicePlansModel(PlatformDemoDbContext context)
    {
        _context = context;
    }

    public IList<ServicePlan> ServicePlans { get; set; }

    public async Task OnGetAsync()
    {
        ServicePlans = await _context.ServicePlans
            .Include(sp => sp.Timesheets)
            .ToListAsync();
    }
}
