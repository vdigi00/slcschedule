using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SLCSchedule.Models;

namespace SLCSchedule
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee Vincent1 = new Employee("Vincent", "DiGiovanni", Employee.Position.Recreation);
            Employee Billy1 = new Employee("Billy", "Joel", Employee.Position.RSM);
            Employee John1 = new Employee("John", "Doe", Employee.Position.Supervisor);

            employees.Add(John1);
            employees.Add(Vincent1);
            employees.Add(Billy1);

            John1.AddAvailability(10, 0, 13, 0);
            John1.AddAvailability(14, 0, 16, 0);
            John1.AddAvailability(18, 0, 20, 0);

            Vincent1.AddAvailability(8, 0, 12, 0);
            Vincent1.AddAvailability(13, 1, 15, 59);

            Billy1.AddAvailability(5, 0, 12, 0);
            Billy1.AddAvailability(14, 1, 15, 59);
            Billy1.AddAvailability(18, 0, 22, 0);

            Shift shift = new Shift(new TimeRange(14, 0, 16, 0));

            Console.WriteLine("Shift from 14:00 - 16:00");
            foreach (var employee in employees)
            {
                Console.WriteLine("\n" + employee.PrintEmployee());
                Console.WriteLine(employee.PrintAvailability());
                Console.WriteLine("Is available for shift: " + shift.isAvailable(employee));
            }
            
            Console.WriteLine("Press any key to exit...");
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    break;
                }
            }
        }
    }
}