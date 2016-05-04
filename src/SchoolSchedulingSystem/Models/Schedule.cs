using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSchedulingSystem.Models
{
    public class Schedule
    {
        public int ID { get; set; }
        public ScheduleStatus Status { get; set; }
        public decimal Fitness { get; set; }
        public ApplicationUser GeneratedBy { get; set; }
        public ApplicationUser ModifiedBy { get; set; }
        public ApplicationUser VerifiedBy { get; set; }
        public ApplicationUser AcceptedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime VerifiedOn { get; set; }
        public DateTime AcceptedOn { get; set; }
        public bool IsActive { get; set; }
        public School School { get; set; }
    }
}
