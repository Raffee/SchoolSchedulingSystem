using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSchedulingSystem.Models
{
    public class ScheduleItem
    {
        public int ID { get; set; }
        public SchoolClass Class { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
        public int Day { get; set; }
        public int Period { get; set; }
        public Schedule Schedule { get; set; }
        public int BrokenLawsCount { get; set; }
    }
}
