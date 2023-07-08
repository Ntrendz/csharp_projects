using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pythagoras_theorem
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("This Is a Console Application To Calculate Pythagoras Theorem");
            Console.WriteLine("");

            Console.Write("Enter Value For A : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Value For B : ");
            b = Convert.ToDouble(Console.ReadLine());


            c = Math.Sqrt((a * a) + (b*b));
            Console.WriteLine("");
            Console.WriteLine("The  pythagoras theorem with A : " + a + " and B : " + b + " is : " + c);


            Console.ReadKey();

        }
    }
}
