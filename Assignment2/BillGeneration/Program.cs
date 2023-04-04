using System;

namespace BillGeneration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of pizza you brought : ");
            int pizza = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of puffs you brought : ");
            int puffs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of pepsi you brought : ");
            int pepsi = Convert.ToInt32(Console.ReadLine());
            int tot=pizza*200+puffs*40+pepsi*120;
            float gst = (float)tot / 100 * 12;
            float cess = (float)tot / 100 * 5;
            Console.WriteLine("\n---------Bill Details------------\n");
            Console.WriteLine("The cost of pizza is : " + (pizza * 200));
            Console.WriteLine("The cost of puffs is : " + (puffs * 40));
            Console.WriteLine("The cost of pepsi is : " + (pepsi * 120));
            Console.WriteLine("GST 12% is           : " + gst);
            Console.WriteLine("CESS 5% is           : " + cess);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Total price  is      : " + (tot));
            Console.WriteLine("----------------------------------------------");


        }
    }
}