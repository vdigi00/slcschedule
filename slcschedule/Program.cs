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
        public static void options()
        {
            Console.WriteLine("1. Create/Modify employee");
            try
            {
                Console.WriteLine("Select an option: ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please select a vaild option:");
                options();
            }
        }

        public void createEmployee()
        {
            Console.WriteLine("Create Employee");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the SLC Schedule Creator, would would you like to do?");
                options();
            }       
        }
    }
}