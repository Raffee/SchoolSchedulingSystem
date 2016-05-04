using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSchedulingSystem.Models
{
    public class Department
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public School School { get; set; }
        public Teacher Head { get; set; }
    }
}
