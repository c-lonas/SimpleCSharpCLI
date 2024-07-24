// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if (args.Length > 0)
            {
                Console.WriteLine("Hello, " + String.Join(" ", args) + "!");
            }
            else
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
}
