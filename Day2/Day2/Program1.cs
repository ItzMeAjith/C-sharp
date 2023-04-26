//2. Write a C# program to display whether a given number is a positive or negative or zero.
using System;
namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
                Console.WriteLine(n + " is Positive");
            else if (n < 0)
                Console.WriteLine(n + " is Negative");
            else
                Console.WriteLine(n + " is Zero");
        }
    }
}