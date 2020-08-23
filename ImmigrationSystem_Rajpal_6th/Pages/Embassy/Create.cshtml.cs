using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ImmigrationSystem_Rajpal_6th.Bussiness;
using ImmigrationSystem_Rajpal_6th.Data;

namespace ImmigrationSystem_Rajpal_6th.Pages.Embassy
{
    public class CreateModel : PageModel
    {
        private readonly ImmigrationSystem_Rajpal_6th.Data.ApplicationDbContext _context;

        public CreateModel(ImmigrationSystem_Rajpal_6th.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Bussiness.Embassy Embassy { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Embassies.Add(Embassy);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
