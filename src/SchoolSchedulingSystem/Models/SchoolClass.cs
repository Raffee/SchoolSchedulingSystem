using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSchedulingSystem.Models
{
    public class SchoolClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ClassLevel ClassLevel { get; set; }
        public School School { get; set; }
    }
}