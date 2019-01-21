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
            if (context.Beaches.Any())
            {
                return;   // DB has been seeded
            }

            var Beaches = new Beaches[]

            {
            new Beaches{BeachesID=1,Rating="Alexander",Location="Cornwall"},
            new Beaches{BeachesID=2,Rating="Alexander",Location="Cornwall"},
            new Beaches{BeachesID=3,Rating="Alexander",Location="Cornwall"},
            };
            foreach (Beaches s in Beaches)
            {
                context.Beaches.Add(s);
            }
            context.SaveChanges();

           

            var Feedbacks = new Feedback[]
            {
            new Feedback{FeedbackID=1,Grade=Grade.A},
            new Feedback{FeedbackID=2,Grade=Grade.C},
            new Feedback{FeedbackID=3,Grade=Grade.B},        
            };
            foreach (Feedback e in Feedbacks)
            {
                context.Feedback.Add(e);
            }
            context.SaveChanges();
        }
    }
}