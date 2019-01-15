using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCustomisationTest.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int Beach { get; set; }
        public int ApplicationUser { get; set; }
        public Grade? Grade { get; set; }
     
    }
}
