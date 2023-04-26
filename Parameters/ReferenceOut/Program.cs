using System;
namespace ReferenceOut
{
    public class program
    {
        public static void sam(out int n)
        {
            int a = n;
            a *= a;
            Console.WriteLine("Inside Method :" + n);
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter value : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before method : "+n);
            sam(out n);
            Console.WriteLine("After method : " + n);


        }
    }
}