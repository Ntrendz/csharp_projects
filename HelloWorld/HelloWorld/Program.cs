using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            Console.WriteLine("Hello Nelson!");
            Foriteration();
            add();
            Console.ReadKey();
          
        }

        static void add()
        {
          
            int x, y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
           

            Console.WriteLine("What is your Name");
            Console.Write("Type your First Name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your Last Name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
        }

        static void Foriteration()
        {
            for (int i = 0; i < 10; i++)
            {
               // Console.WriteLine(i);
               if (i == 7)
                {
                    Console.WriteLine("Found Seven");
                    break;
                }
            }

            for (int myvalue = 0; myvalue < 12; myvalue++)
            {
                Console.WriteLine(myvalue);
            }

        }
    }
}
