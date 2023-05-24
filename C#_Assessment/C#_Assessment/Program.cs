using System;

namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j,n;
            int c = 1;
            try
            {
                Console.Write("Enter the value of n to print pattern : ");
                n=Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <=n; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write(c + "\t");
                        c++;
                    }
                    Console.WriteLine("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong : "+e.Message);
            }
        }
    }
}
