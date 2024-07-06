using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SLCSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee Vincent1 = new Employee("Vincent", "DiCarlo", Employee.Position.Recreation);
            Employee Billy1 = new Employee("Billy", "Joel", Employee.Position.RSM);
            Employee John1 = new Employee("John", "Doe", Employee.Position.Supervisor);

            employees.Add(Vincent1);
            employees.Add(Billy1);
            employees.Add(John1);

            John1.AddAvailability(10, 0, 14, 0);
            John1.AddAvailability(18, 0, 20, 0);

            Vincent1.AddAvailability(8, 0, 12, 0);
            Vincent1.AddAvailability(15, 0, 20, 0);

            Billy1.AddAvailability(5, 0, 12, 0);
            Billy1.AddAvailability(18, 0, 22, 0);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.PrintEmployee());
                Console.WriteLine(employee.PrintAvailability());
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