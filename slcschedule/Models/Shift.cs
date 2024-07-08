using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLCSchedule.Models
{
    public class Shift
    {
        private TimeRange timeRange;
        private int availCount;
        private enum Location
        {
            CAGE,
            SLC,
            FH
        }

        public Shift(TimeRange _timeRange)
        {
            timeRange = _timeRange;
            availCount = 0;
        }

        public TimeRange getTimeRange()
        {
            return timeRange;
        }

        public TimeSpan getShiftStart()
        {
            return timeRange.getStart();
        }

        public bool isAvailable(Employee employee)
        {
            foreach (var range in employee.GetAvailability())
            {
                if(timeRange.getStart() < range.getEnd() && timeRange.getEnd() > range.getStart())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
