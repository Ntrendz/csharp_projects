using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    class Demo
    {
        string country;
        string name;
        int age;


        public Demo(string Name, string Country, int Age)
        {
            name = Name;
            country = Country;
            age = Age;
        }

        public void Display()
        {
            WriteLine("let us test if its going to work");

            ForegroundColor = ConsoleColor.Cyan;
            WriteLine($"My name is {name} and am from {country} and am {age} years old\n ");

            ForegroundColor = ConsoleColor.White;

            inputs();
        }
        public void inputs()
        {
            WriteLine("talk about your self");
            string about = ReadLine();
            Write(about);

        }     
    }
   
}
