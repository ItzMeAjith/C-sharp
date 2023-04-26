using System;

namespace Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] input = { {1, 2, 3, 4, 5, 6, 7 },{ 8, 9, 10, 11, 12, 13,14 },{ 15, 16, 17, 18, 19, 20, 21 } };
            Console.WriteLine(input.GetLength(1));
            Console.WriteLine(input.GetLength(0));
        }
    }
}