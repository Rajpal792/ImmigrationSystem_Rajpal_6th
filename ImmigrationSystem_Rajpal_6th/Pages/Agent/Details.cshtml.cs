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
    public class DetailsModel : PageModel
    {
        private readonly ImmigrationSystem_Rajpal_6th.Data.ApplicationDbContext _context;

        public DetailsModel(ImmigrationSystem_Rajpal_6th.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Bussiness.Agent Agent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Agent = await _context.Agents.FirstOrDefaultAsync(m => m.ID == id);

            if (Agent == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
