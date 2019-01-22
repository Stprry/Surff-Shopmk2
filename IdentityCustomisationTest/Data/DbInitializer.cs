﻿using IdentityCustomisationTest.Models;
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
            new Beach{BeachID=1,Rating="Alexander",Location="Cornwall"},
            new Beach{BeachID=2,Rating="Alexander",Location="Cornwall"},
            new Beach{BeachID=3,Rating="Alexander",Location="Cornwall"},
            };
            foreach (Beach s in Beaches)
            {
                context.Beach.Add(s);
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