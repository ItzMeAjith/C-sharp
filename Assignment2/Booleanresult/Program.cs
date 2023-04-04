//Registration Form
using System;

namespace Booleanresult
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the value for X : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value for Y : ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool b=true;
            if (x > y)
            {
                b = false;
            }
            Console.WriteLine($"The result of whether X is less than Y is {b}");
        }
    }
}