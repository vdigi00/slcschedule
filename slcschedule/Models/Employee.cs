﻿using System;
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

        public enum Position
        {
            Recreation,
            Supervisor,
            RSM
        }

        public void AddAvailability(int startHour, int startMin, int endHour, int endMin)
        {
            TimeRange range = new TimeRange(new TimeSpan(startHour, startMin, 0), new TimeSpan(endHour, endMin, 0));
            availability.Add(range);
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
                sb.AppendLine($"Availability Start: {range.getStart()}, Availability End: {range.getEnd()}");
            }
            return sb.ToString();
        }

        public Employee(string _firstname, string _lastname, Position _position)
        {
            firstname = _firstname;
            lastname = _lastname;
            position = _position;
            availability = new List<TimeRange>();
        }
    }
}
