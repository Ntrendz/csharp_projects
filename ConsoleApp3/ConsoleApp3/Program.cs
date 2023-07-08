using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Texting Favours Brain";
            Console.WriteLine("===================");
            Console.WriteLine("Hello world");
            Console.WriteLine("===================");


            Demo Mydemo = new Demo("Favour","Nigeria", 18);
            Mydemo.Display();


            Console.WriteLine("\nPress any key to exits...");
            Console.ReadKey();
        }
    }
}
