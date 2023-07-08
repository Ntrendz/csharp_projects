using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, disc, deno, x1, x2;

            Console.WriteLine("This is a Program To Calculate Quadratic Equation ");
            Console.WriteLine("");

            Console.Write("Enter Value For A : ");
            a = Convert.ToDouble (Console.ReadLine() );

            Console.Write("Enter Value For B : ");
            b = Convert.ToDouble(Console.ReadLine() );

            Console.Write("Enter Value For c : ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            if (a == 0)
            {
                x1 = -b;
                Console.WriteLine("The roots are Linear: "+ x1);
            }

            else 
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;
               
                {
                    Console.WriteLine("THE ROOTS ARE REAL AND DISTINCT ROOTS");
                    x1 = (-b + (Math.Sqrt(disc)) )/ deno;
                    x2 = (-b - (Math.Sqrt(disc)) )/ deno;
                    Console.WriteLine("THE ROOTS ARE... " + x1 + " and " + x2);
                }
               


                }
            

            Console.ReadKey();
        }

    }
}
