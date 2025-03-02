using System;

namespace demoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Demo Project!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
