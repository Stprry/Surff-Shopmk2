using IdentityCustomisationTest.Models;
using SurfShop.Data;
using System;
using System.Linq;

namespace IdentityCustomisationTest.Models
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // context.Database.EnsureCreated();

            // Look for any Beachess.
            if (context.Beach.Any())
            {
                return;   // DB has been seeded
            }

            var Beaches = new Beach[]

            {
            new Beach{Rating="A",Location="Cornwall"},
            new Beach{Rating="B",Location="Crash Boat Beach"},
            new Beach{Rating="D",Location="Larga Beach"},
            new Beach{Rating="C",Location="Boulder Beach"},
            new Beach{Rating="A",Location="James Bond Beach"},
            new Beach{Rating="F",Location="Porto-Vecchio"},
            new Beach{Rating="D",Location="Redonda Beach"},
            new Beach{Rating="B",Location="Praia da Nazaré "},
            };
            foreach (Beach s in Beaches)
            {
                context.Beach.Add(s);
            }
            context.SaveChanges();

           

            var Feedbacks = new Feedback[]
            {
            new Feedback{Grade=Grade.A,Beach=1,ApplicationUser=1},
            new Feedback{Grade=Grade.B,Beach=1,ApplicationUser=1},
            new Feedback{Grade=Grade.C,Beach=1,ApplicationUser=1},
            new Feedback{Grade=Grade.D,Beach=2,ApplicationUser=1},
            new Feedback{Grade=Grade.F,Beach=2,ApplicationUser=1},
            };
            foreach (Feedback e in Feedbacks)
            {
                context.Feedback.Add(e);
            }
            context.SaveChanges();
        }
    }
}