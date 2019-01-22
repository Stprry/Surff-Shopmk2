using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IdentityCustomisationTest.Models;

namespace IdentityCustomisationTest.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly IdentityCustomisationTest.Models.BeachContext _context;

        public IndexModel(IdentityCustomisationTest.Models.BeachContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
