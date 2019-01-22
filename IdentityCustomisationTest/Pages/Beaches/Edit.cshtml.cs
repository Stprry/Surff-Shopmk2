using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IdentityCustomisationTest.Models;
using SurfShop.Data;

namespace IdentityCustomisationTest.Pages.Beaches
{
    public class EditModel : PageModel
    {
        private readonly SurfShop.Data.ApplicationDbContext _context;

        public EditModel(SurfShop.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Beach Beach { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Beach = await _context.Beach.FirstOrDefaultAsync(m => m.BeachID == id);

            if (Beach == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Beach).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeachExists(Beach.BeachID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BeachExists(int id)
        {
            return _context.Beach.Any(e => e.BeachID == id);
        }
    }
}
