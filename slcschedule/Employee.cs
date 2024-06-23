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
        public List<Tuple<TimeSpan, TimeSpan>> availability;

        //This is a test

        public enum Position{
            Recreation, 
            Supervisor, 
            RSM
        }

        public void AddAvailability(TimeSpan start, TimeSpan end)
        {
            var block = Tuple.Create(start, end);
            availability.Add(block);
        }

        public Employee(string _name, Position _position, List<Tuple<TimeSpan, TimeSpan>> _availability)
        {
            name = _name;
            position = _position;
            availability = new List<Tuple<TimeSpan, TimeSpan>>();
        }
    }
}
