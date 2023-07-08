using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{





    class Program
    {

        public int factorial(int num)
        {
            /* local variable declaration */
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }




        static void Main(string[] args)
        {
           

            /*Constant Declaration */
            const double d = Math.PI;
            Console.WriteLine(d);

            // CHANGING THE VALUE INSIDE AN ARRAY
            string[] name = new string[] { "Nelson", "Florence", "Donald", "Efe" };
            Console.Write("Enter Name: ");
           name[0] = Console.ReadLine();
            Console.WriteLine(name [0]);

            // Calculating Factorial

            Program n = new Program();
            //calling the factorial method {0}", n.factorial(6));
            Console.WriteLine("Factorial of 6 is : {0}", n.factorial(6));
            Console.WriteLine("Factorial of 7 is : {0}", n.factorial(7));
            Console.WriteLine("Factorial of 8 is : {0}", n.factorial(8));
            Console.ReadLine();


            // Nullables
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0} ", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0} ", num3);
            Console.ReadLine();

            Console.ReadKey();
        }


    }
}
