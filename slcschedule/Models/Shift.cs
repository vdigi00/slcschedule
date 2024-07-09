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

        /*
        public bool isAvailable(Employee employee)
        {
            foreach (var range in employee.GetAvailability())
            {
                if (range.getStart() <= timeRange.getStart() && range.getEnd() >= timeRange.getEnd())
                {
                    return true;
                }
            }
            return false;
        }
        */

        public bool isAvailable(Employee employee)
        {
            return employee.GetAvailability().Any(range => range.getStart() <= timeRange.getStart() && range.getEnd() >= timeRange.getEnd());
        }
    }
}
