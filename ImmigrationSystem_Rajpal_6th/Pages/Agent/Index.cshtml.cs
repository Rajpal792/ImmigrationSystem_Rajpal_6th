using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ImmigrationSystem_Rajpal_6th.Bussiness;
using ImmigrationSystem_Rajpal_6th.Data;

namespace ImmigrationSystem_Rajpal_6th.Pages.Agent
{
    public class IndexModel : PageModel
    {
        private readonly ImmigrationSystem_Rajpal_6th.Data.ApplicationDbContext _context;

        public IndexModel(ImmigrationSystem_Rajpal_6th.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Bussiness.Agent> Agent { get;set; }

        public async Task OnGetAsync()
        {
            Agent = await _context.Agents.ToListAsync();
        }
    }
}
