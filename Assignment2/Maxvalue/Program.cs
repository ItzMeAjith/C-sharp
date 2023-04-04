using System;

namespace Maxvalue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            sbyte n=125;
            Console.WriteLine("Value of number : "+n);
            n = sbyte.MaxValue;
            Console.Write("Largest value stored in a single number : " +n);
        }
    }
}