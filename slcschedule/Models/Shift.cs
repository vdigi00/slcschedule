using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLCSchedule.Models
{
    class Shift
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
    }
}
