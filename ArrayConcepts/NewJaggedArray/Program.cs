using System;

namespace NewJaggedArray
{

    internal class Program
    {
        public static void display(int n, int[][] overs)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s = 0;
                Console.Write($"The total runs scored by {i + 1} th team in each ball is : [ ");
                for (int j = 0; j < overs[i].Length; j++)
                {
                    Console.Write(overs[i][j] + " ");
                    s += overs[i][j];
                }
                Console.Write("]  ");
                Console.WriteLine($"The total run scored by {i+1}th team is {s}");
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Enter the no of teams : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] overs = new int[n][];
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the no of balls used by the {i + 1}th team : ");
                overs[i] = new int[Convert.ToInt32(Console.ReadLine())];
                Console.WriteLine("\n----------------------------------------------------------------------------\n");
                for (int j = 0; j < overs[i].Length; j++)
                {
                    Console.Write($"Enter the runs scored by {i + 1}th team in {j + 1}th ball is : ");
                    overs[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n----------------------------------------------------------------------------\n");
            }
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            display(n, overs);
            /*
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < overs[i].Length; j++)
                {
                    Console.Write(overs[i][ j] + " ");
                }
                Console.WriteLine();
            }*/


        }
    }
}