//1.Write a C# Program to display the prime number from 1 to 100.
using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 1;
            Console.WriteLine("The prime number from 1 to 100 is : ");
            for(int i=2;i<=100;i++)
            {
                
                for(int j=2;j<=100;j++)
                {
                    f = 1;
                    if(i%j==0 && i!=j)
                    {
                        f=0; break;
                    }
                }
                if (f == 1)
                {
                    Console.WriteLine(i);
                }
            }
           
        }
    }
}