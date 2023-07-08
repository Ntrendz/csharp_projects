 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args) 
        {
            if (DateTime.Now.DayOfWeek==DayOfWeek.Tuesday)   
            {
                Console.WriteLine("Another case of the Tuesday!");
            }
            else
            {
                Console.WriteLine("Today is not Tuesday");
            }
             
            Console.Write("Your Name ");
            string name = Console.ReadLine();

            Console.Write("How many hours of sleep did you get last night ");
            double hoursOfSleep = double.Parse(Console.ReadLine());

            Console.WriteLine("Hello," + name);

            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("You are well rested");
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }

            Console.ReadKey(); 
        }
    }
}
