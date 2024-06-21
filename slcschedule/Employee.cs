using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slcschedule
{
    class Employee
    {
        public string name;

        public enum Position{
            Recreation, Supervisor, RSM
        }

        public Employee(string _name)
        {
            name = _name;
        }

    }
}
