using System;

namespace VisualStudio_2019_C_Sharp_Git_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Here is a change");

            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            //Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("Hello {0}!", name);
        }
    }
}
