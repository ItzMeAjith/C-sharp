using System;
using System.Linq;

namespace LinqArrayConcat
{
   internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = { 1, 3,5,7,9};
            int[] ar2 = { 2,4,6,8,10};
            var result = from item in ar1 where item.GetType() == typeof(int) select item.GetType;
            
            foreach ( var item in result )
            {
                Console.WriteLine(item);
            }
        }
    }

}