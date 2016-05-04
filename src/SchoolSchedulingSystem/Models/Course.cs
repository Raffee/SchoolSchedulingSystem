using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSchedulingSystem.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CourseLevel CourseLevel { get; set; }
        public Department Department { get; set; }
        public School School { get; set; }
    }
}
