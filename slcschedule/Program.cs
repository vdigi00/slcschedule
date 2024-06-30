using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace slcschedule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee("John", "Doe", Employee.Position.Supervisor));
            employees.Add(new Employee("Vincent", "DiCarlo", Employee.Position.Recreation));
            employees.Add(new Employee("Billy", "Joel", Employee.Position.RSM));
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine(employee.PrintEmployee());
                //Console.WriteLine(employee.PrintAvailability())
            }
            /*
            John1.AddAvailability(10, 0, 14, 0);
            John1.AddAvailability(18, 0, 20, 0);
            Console.WriteLine(John1.PrintEmployee());
            Console.WriteLine(John1.PrintAvailability());

            
            Vincent1.AddAvailability(8, 0, 12, 0);
            Vincent1.AddAvailability(15, 0, 20, 0);
            Console.WriteLine(Vincent1.PrintEmployee());
            Console.WriteLine(Vincent1.PrintAvailability());

            
            Billy1.AddAvailability(5, 0, 12, 0);
            Billy1.AddAvailability(18, 0, 22, 0);
            Console.WriteLine(Billy1.PrintEmployee());
            Console.WriteLine(Billy1.PrintAvailability());
            */
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