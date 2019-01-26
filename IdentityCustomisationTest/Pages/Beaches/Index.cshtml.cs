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
    public class IndexModel : PageModel
    {
        private readonly SurfShop.Data.ApplicationDbContext _context;

        public IndexModel(SurfShop.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public string LocationSort { get; set; }
        public string RatingSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<Beach> Beach { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;


            LocationSort = String.IsNullOrEmpty(sortOrder) ? "location_desc" : "";
            RatingSort = String.IsNullOrEmpty(sortOrder) ? "rating_desc" : "";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = CurrentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Beach> BeachIQ = from s in _context.Beach
                                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                BeachIQ = BeachIQ.Where(s =>
                                        s.Location.Contains(searchString)
                                       || s.Rating.Contains(searchString));
            }

            switch (sortOrder)
            {

                case "location_desc":
                    BeachIQ = BeachIQ.OrderBy(s => s.Location);
                    break;
                case "rating_desc":
                    BeachIQ = BeachIQ.OrderBy(s => s.Rating);
                    break;
                default:
                    BeachIQ = BeachIQ.OrderBy(s => s.BeachID);
                    break;
            }
            int pageSize = 6;
            Beach = await PaginatedList<Beach>.CreateAsync(
        BeachIQ.AsNoTracking(), pageIndex ?? 1, pageSize);



        }
    }

}
