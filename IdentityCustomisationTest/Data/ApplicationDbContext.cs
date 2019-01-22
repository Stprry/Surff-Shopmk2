using System;
using System.Collections.Generic;
using System.Text;
using SurfShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityCustomisationTest.Models;

namespace SurfShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Beach> Beach { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
    }
}
