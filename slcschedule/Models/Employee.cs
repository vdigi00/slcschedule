using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLCSchedule.Models
{
    public class Employee
    {
        private string firstname;
        private string lastname;
        private Position position;
        private List<TimeRange> availability;

        [Flags]
        public enum Position
        {
            None = 0,
            Recreation = 1 << 0,
            Supervisor = 1 << 1,
            RSM = 1 << 2
        }

        public Employee(string _firstname, string _lastname, Position _position)
        {
            firstname = _firstname;
            lastname = _lastname;
            position = _position;
            availability = new List<TimeRange>();
        }

        public void AddAvailability(int startHour, int startMin, int endHour, int endMin)
        {
            TimeRange range = new TimeRange(startHour, startMin, endHour, endMin);
            availability.Add(range);
        }

        public List<TimeRange> GetAvailability()
        {
            return availability;
        }

        public string PrintEmployee()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Employee Info:");
            sb.AppendLine("Name: " + firstname + " " + lastname + " - Position: " + position.ToString());
            return sb.ToString();
        }

        public string PrintAvailability()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var range in availability)
            {
                sb.AppendLine($"Availability Start: {range.printStart()}, Availability End: {range.printEnd()}");
            }
            return sb.ToString();
        }
    }
}
