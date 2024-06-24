using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slcschedule
{
    class Employee
    {
        private string name;
        private Position position;
        private List<Tuple<TimeSpan, TimeSpan>> availability;
        public enum Position{
            Recreation, 
            Supervisor, 
            RSM
        }

        public void AddAvailability(int startHour, int startMin, int endHour, int endMin)
        {
            TimeSpan start = new TimeSpan(startHour, startMin, 0);
            TimeSpan end = new TimeSpan(endHour, endMin, 0);
            var block = Tuple.Create(start, end);
            availability.Add(block);
        }

        public string PrintEmployee()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Employee Info:");
            sb.AppendLine("Name: " + name + " | Position: " + position.ToString());
            return sb.ToString();
        }

        public string PrintAvailability()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var tuple in availability)
            {
                sb.AppendLine($"Availability Start: {tuple.Item1}, Availability End: {tuple.Item2}");
            }
            return sb.ToString();
        }

        public Employee(string _name, Position _position)
        {
            name = _name;
            position = _position;
            availability = new List<Tuple<TimeSpan, TimeSpan>>();
        }
    }
}
