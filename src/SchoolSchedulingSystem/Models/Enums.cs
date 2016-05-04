using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSchedulingSystem.Models
{
    public enum AvailabilityType
    {
        FullTime,
        PartTime
    }

    public enum ClassLevel
    {
        KG1,
        KG2,
        ELEM1
    }

    public enum CourseLevel
    {
        Easy,
        Intermediate,
        Advanced
    }

    public enum ScheduleStatus
    {
        Invalid,
        Valid,
        Active
    }
}
