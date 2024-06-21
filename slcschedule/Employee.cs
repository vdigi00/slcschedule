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
        public Position position;
        // public List<availPeriod> 

        public enum Position{
            Recreation, 
            Supervisor, 
            RSM
        }
        /*
        public List<> availRange(TimeSpan start, TimeSpan end)
        {
            
        }
        */

        public Employee(string _name, Position _position)
        {
            name = _name;
            position = _position;
        }
    }
}
