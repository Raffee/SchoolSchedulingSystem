using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSchedulingSystem.Models
{
    public class TeacherAvailability
    {
        public int ID { get; set; }
        public Teacher Teacher { get; set; }
        public int Day { get; set; }
        public int Period { get; set; }
    }
}
