using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSchedulingSystem.Models
{
    public class SchoolConfiguration
    {
        public int ID { get; set; }
        public int SchoolID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
