using System;

namespace ArrayConcepts
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of an array : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[]arr=new int[n];
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write($"Enter {i} th element : ");

                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            MAX(arr);
            MIN(arr);
        }
        public static void Sort(int[] arr)
        {
            int temp = arr[0];
            for(int i= 0;i < arr.Length;i++)
            {
                if (i > i+1)
                {
                   temp= arr[i];
                    arr[i+1] = i;

                }
            }

        }
        public static void MAX(int[] arr)
        {
            int max = arr[0];
            foreach(int i in arr)
            {
                if(i>max)
                {
                    max = i;
                }
            }
            Console.WriteLine("Max is :"+max);
        }
        public static void MIN(int[] arr)
        {
            int min= arr[0];
            foreach (int i in arr)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine("Min is :" + min);
        }
    }
}