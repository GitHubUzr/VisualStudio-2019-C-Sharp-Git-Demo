/*
 * This C# Console Application code is meant to follow
 * Hello World project as well as receive
 * user input and respond with user name
 */

using System;

namespace VisualStudio_2019_C_Sharp_Git_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Here is a change");


            //asks for user input
            Console.WriteLine("What is your name?");
            Console.WriteLine("Enter in the line below:");

            //receives user input
            string name;
            name = Console.ReadLine();

            /*
             * This is another way to combine literal and variable
             * Console.WriteLine("Hello " + name + "!");
             */
            //returns name in message
            Console.WriteLine("Hello {0}!", name);
        }
    }
}
