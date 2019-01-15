using IdentityCustomisationTest.Models;
using System;
using System.Linq;

namespace IdentityCustomisationTest.Models
{
    public static class DbInitializer
    {
        public static void Initialize(Beaches context)
        {
            // context.Database.EnsureCreated();

            // Look for any Beachess.
            if (context.BeachesID.Any())
            {
                return;   // DB has been seeded
            }

            var Beaches = new Beaches[]

            {
            new Beaches{BeachesID=1,Rating="Alexander",Location="Cornwall"},
            new Beaches{BeachesID=2,Rating="Alexander",Location="Cornwall"},
            new Beaches{BeachesID=3,Rating="Alexander",Location="Cornwall"},
            };
            foreach (Beaches s in Beachess)
            {
                context.Beaches.Add(s);
            }
            context.SaveChanges();

           

            var Feedbacks = new Feedback[]
            {
            new Feedback{BeachesID=1,Grade=Grade.A},
            new Feedback{BeachesID=2,Grade=Grade.C},
            new Feedback{BeachesID=3,Grade=Grade.B},        
            };
            foreach (Feedback e in Feedbacks)
            {
                context.Feedback.Add(e);
            }
            context.SaveChanges();
        }
    }
}