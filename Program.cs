using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling a method, this can be done many times; methods and functions
            // are literally the same in C#, preferably call them methods
            SayHi();

            // Method with parameters 
            SayHiUser("Evans");

            // Method with more parameters
            SayHiAge("John", 55);

            // FREEZING THE CONSOLE
            Console.ReadLine();
        }

        static void SayHi()
        {
            Console.WriteLine("Hi");
        }

        static void SayHiUser(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static void SayHiAge(string name, int age)
        {
            Console.WriteLine($"Hello {name}, You are {age} years old.");
        }
    }
}
