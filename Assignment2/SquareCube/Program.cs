//Square and cube of a number
using System;

namespace SquareCube
{
    internal class Program
    {
        public static double square(double x)
        {
            return x * x;
        }
        public static  double cube(double x)
        {
            return x*x*x;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find square and cube : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Square of {num} is {square(num)}");
            Console.WriteLine($"cube of {num} is {cube(num)}");
        }
    }
}