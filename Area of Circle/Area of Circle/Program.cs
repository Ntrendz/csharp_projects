using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Radius();


        }

        static void Radius()
        {
            double area, r;

            Console.WriteLine("This Is a Console Application To Calculate The Area Of a Circle");
            Console.WriteLine("");
            Console.Write("Enter Value For Radius : ");
            r = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * (r * r);
            Console.WriteLine("");
            Console.WriteLine("The  Area Of a Circle with radius " + r + " is : " + area);


            for (; ; )
            {
                Console.WriteLine("");
                Console.Write("Enter Value For Radius : ");
                r = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * (r * r);
                Console.WriteLine("");
                Console.WriteLine("The  Area Of a Circle with radius " + r + " is : " + area);
            }
        }
    }
}
