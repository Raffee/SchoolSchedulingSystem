using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSchedulingSystem.Models
{
    public class Teacher
    {
        public int ID { get; set; }

        [Display(Name = "Registration Date")]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Availability Type")]
        public AvailabilityType AvailabilityType { get; set; }
        public ApplicationUser User { get; set; }
        public School School { get; set; }
    }
}
