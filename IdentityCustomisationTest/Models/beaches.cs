using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IdentityCustomisationTest.Models
{
    public class Beaches
    {
        public int BeachesID { get; set; }
        
        public string Rating { get; set; }
        public string Location { get; set; }
        [StringLength(25, ErrorMessage = "Beach Location cannot be longer than 25 characters.")]
        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
