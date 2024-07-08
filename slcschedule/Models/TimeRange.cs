using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SLCSchedule.Models.Employee;

namespace SLCSchedule.Models
{
    class TimeRange
    {
        private TimeSpan Start;
        private TimeSpan End;

        public TimeRange(TimeSpan _start, TimeSpan _end)
        {
            Start = _start; 
            End = _end;
        }

        public String getStart()
        {
            return Start.ToString();
        }
        public String getEnd()
        {
            return End.ToString();
        }

        public bool Overlaps(TimeRange check)
        {
            return Start < check.End && End > check.Start;
        }
    }
}
