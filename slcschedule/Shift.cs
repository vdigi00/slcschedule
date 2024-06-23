using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slcschedule
{
    class Shift
    {
        public TimeSpan start;
        public TimeSpan end;
        public string location;
        public int availCount;
        public Employee employee;

        public Shift(TimeSpan _start, TimeSpan _end, string _location)
        {
            start = _start;
            end = _end;
            location = _location;
            availCount = 0;
        }
    }
}
