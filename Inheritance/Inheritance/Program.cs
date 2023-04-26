using System;

namespace Inheritance
{
    public class vehicle
    {
        public int vno;
        public string vehicleType;
        public void display()
        {
            Console.WriteLine("Vehicle number is : " + vno);
            Console.WriteLine("Vehicle type is : " + vehicleType);
        }
    }
    public class car : vehicle 
    {
        public string brand;
        public int myear;
        public string color;
        public void show()
        {
            Console.WriteLine("Car brand is : " + brand);
            Console.WriteLine("Car manufactured year is : " + myear);
            Console.WriteLine("Car color is : " + color);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car c= new car();
            Console.Write("Enter vehicle no : ");
            c.vno =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter vehicle type : ");
            c.vehicleType = Console.ReadLine();
            Console.Write("Enter car brand name : ");
            c.brand= Console.ReadLine();
            Console.Write("Enter car manufactured year : ");
            c.myear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter car color : ");
            c.color= Console.ReadLine();
            Console.WriteLine("--------------------Base class details------------------\n");
            c.display();
            Console.WriteLine("\n--------------------Derived class details------------------\n");
            c.show();
        }
    }
}