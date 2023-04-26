using System;

namespace MultiDimentionalArray
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter no of rows : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no of columns : ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] arr=new int[r,c];
            for(int i=0;i<r;i++)
            {
                //Console.WriteLine($"Enter the values of {i+1} row ");
                for(int j=0;j<c;j++)
                {
                    Console.Write($"Enter the values of {i} row and {j} column : ");
                    arr[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i,j] +" ");
                }
                Console.WriteLine();
            }


        }
    }
}