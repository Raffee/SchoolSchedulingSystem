using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSchedulingSystem.Models
{
    public class School
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Abbreviation { get; set; }
        public bool IsActive { get; set; }
        public Address Address { get; set; }
        public ApplicationUser Manager { get; set; }
        public bool IsDeleted { get; set; }
    }
}
