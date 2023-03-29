using System;
namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of an array : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[n];
            Console.WriteLine("Enter the Values for array : ");
            for(int i=0; i<n; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The array is : ");
            for (int i = 0; i < n; i++)
            {
                /*if (arr[i]%2==0)
                {
                    Console.Write(arr[i] + "\t");
                }*/
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine("\nThe reverse array is : ");
            int c = n-1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[c-i] + "\t");
            }
        }
    }
}