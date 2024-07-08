using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLCSchedule.Models
{
    public class TimeRange
    {
        private TimeSpan Start;
        private TimeSpan End;

        public TimeRange(int startHour, int startMin, int endHour, int endMin)
        {
            Start = new TimeSpan(startHour, startMin, 0);
            End = new TimeSpan(endHour, endMin, 0);
        }

        public TimeSpan getStart()
        {
            return Start;
        }

        public TimeSpan getEnd()
        {
            return End;
        }

        public String printStart()
        {
            return Start.ToString();
        }

        public String printEnd()
        {
            return End.ToString();
        }
    }
}
