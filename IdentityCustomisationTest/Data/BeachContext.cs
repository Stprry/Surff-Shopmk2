using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IdentityCustomisationTest.Models
{
    public class BeachContext : DbContext
    {
        public BeachContext(DbContextOptions<BeachContext> options)
            : base(options)
        {
        }
        public DbSet<User> UserTest { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Beaches> Beache { get; set; }
    


    public DbSet<IdentityCustomisationTest.Models.User> User { get; set; }
    }
}
