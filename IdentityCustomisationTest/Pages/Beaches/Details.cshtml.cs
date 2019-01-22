using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IdentityCustomisationTest.Models;
using SurfShop.Data;

namespace IdentityCustomisationTest.Pages.Beaches
{
    public class DetailsModel : PageModel
    {
        private readonly SurfShop.Data.ApplicationDbContext _context;

        public DetailsModel(SurfShop.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
