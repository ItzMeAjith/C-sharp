using System;

namespace Overiding
{
    public class vehicle
    {
        public int vno;
        public string vehicleType;
        public virtual void display()
        {
            Console.WriteLine("--------------------Base class details------------------");
            Console.WriteLine("Vehicle number is : " + vno);
            Console.WriteLine("Vehicle type is : " + vehicleType);
        }
    }
    public class car : vehicle
    {
        public string brand;
        public int myear;
        public string color;
        public override void display()
        {
            base.display();
            Console.WriteLine("--------------------First Derived class details------------------");
            Console.WriteLine("Car brand is : " + brand);
            Console.WriteLine("Car manufactured year is : " + myear);
            Console.WriteLine("Car color is : " + color);
        }
    }
    public class owner:car
    {
        public string name;
        public string location;
        public override void display()
        {
            
            Console.WriteLine("--------------------Second Derived class details------------------");
            Console.WriteLine("Car owner is : " + name);
            Console.WriteLine("Owner location is : " + location);
            base.display();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            owner c = new owner();
            Console.Write("Enter Owner : ");
            c.name = Console.ReadLine();
            Console.Write("Enter owner location : ");
            c.location= Console.ReadLine();
            Console.Write("Enter vehicle no : ");
            c.vno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter vehicle type : ");
            c.vehicleType = Console.ReadLine();
            Console.Write("Enter car brand name : ");
            c.brand = Console.ReadLine();
            Console.Write("Enter car manufactured year : ");
            c.myear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter car color : ");
            c.color = Console.ReadLine();
            Console.WriteLine("--------------------------------------\n");
            c.display();
            
        }
    }
}