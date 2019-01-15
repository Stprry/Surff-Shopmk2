using Microsoft.EntityFrameworkCore;

namespace IdentityCustomisationTest.Models
{
    public class BeachesContext : DbContext
    {
        public BeachesContext(DbContextOptions<BeachesContext> options)
            : base(options)
        {
        }


        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Beaches> Beaches { get; set; }
    }
}