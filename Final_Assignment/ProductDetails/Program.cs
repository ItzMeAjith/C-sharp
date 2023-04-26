using System;

namespace ProductDetails
{
    class Products
    {
        public string productName { get; set; }
        public string serialNumber{ get; set; }
        public DateTime purchaseDate { get; set; }
        public double cost { get; set; }

      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter total products : ");
            int n = Convert.ToInt32(Console.ReadLine());
            

            Products[] pro= new Products[n];
            for(int i=0;i<n; i++)
            {
                Console.Write("Enter product name : ");
                string name = Console.ReadLine();
                Console.Write("Enter serial number : ");
                string serial = Console.ReadLine();
                Console.Write("Enter purchase date in the format of yyyy/mm/dd : ");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter product cost : ");
                double cost = Convert.ToDouble(Console.ReadLine());
                pro[i] = new Products(name,serial,date,cost);
            }
        }
    }
}