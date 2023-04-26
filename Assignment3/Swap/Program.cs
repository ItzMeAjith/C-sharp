//4. Write a C# Program to swap two given numbers without using temp variable.
using System;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The numbers before swap is ({a},{b})");
            a = a + b;
            b = a - b;
            a=a-b;
            Console.WriteLine($"The numbers before swap is ({a},{b})");

        }
    }
}