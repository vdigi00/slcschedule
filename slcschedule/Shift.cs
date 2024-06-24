using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slcschedule
{
    class Shift
    {
        private TimeSpan start;
        private TimeSpan end;
        private int availCount;
        private enum Location
        {
            CAGE,
            SLC,
            FH
        }

        public Shift(TimeSpan _start, TimeSpan _end)
        {
            start = _start;
            end = _end;
            availCount = 0;
        }
    }
}
