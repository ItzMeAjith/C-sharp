using System;

namespace ArraySort
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of an array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr= new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the {i}th element : ");
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            //Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.Write($"The array is : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }
            for (int i = 0; i < n; i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.Write($"\nThe array after sorting  is : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.Write($"\nThe reverse of an array after sorting  is : ");
            for (int i = n-1; i>=0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
        }
    }
}