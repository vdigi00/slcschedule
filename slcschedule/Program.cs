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
            Employee John1 = new Employee("John Doe", Employee.Position.Supervisor);
            John1.AddAvailability(10, 0, 14, 0);
            John1.AddAvailability(18, 0, 20, 0);
            Console.WriteLine(John1.PrintEmployee());
            Console.WriteLine(John1.PrintAvailability());
            Console.WriteLine("Press any key to exit...");

            while (true)
            {
                    // Check if a key is pressed
                if (Console.KeyAvailable)
                {
                    // Read the key to clear it from the buffer
                    Console.ReadKey(true);
                    break; // Exit the loop
                }
            }
        }
    }
}