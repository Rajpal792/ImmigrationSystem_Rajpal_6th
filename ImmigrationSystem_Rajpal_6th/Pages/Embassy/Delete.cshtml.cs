using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ImmigrationSystem_Rajpal_6th.Bussiness;
using ImmigrationSystem_Rajpal_6th.Data;

namespace ImmigrationSystem_Rajpal_6th.Pages.Embassy
{
    public class DeleteModel : PageModel
    {
        private readonly ImmigrationSystem_Rajpal_6th.Data.ApplicationDbContext _context;

        public DeleteModel(ImmigrationSystem_Rajpal_6th.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Bussiness.Embassy Embassy { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Embassy = await _context.Embassies.FirstOrDefaultAsync(m => m.ID == id);

            if (Embassy == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Embassy = await _context.Embassies.FindAsync(id);

            if (Embassy != null)
            {
                _context.Embassies.Remove(Embassy);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
