using System;

namespace Private
{
    public class vehicle
    {
        private int vno;
        private string vehicleType;
        public vehicle(int vno, string vehicleType)
        {
            this.vno = vno;
            this.vehicleType = vehicleType;
        }
        public virtual void display()
        {
            Console.WriteLine("--------------------Base class details------------------");
            Console.WriteLine("Vehicle number is : " + vno);
            Console.WriteLine("Vehicle type is : " + vehicleType);
        }
    }
    public class car : vehicle
    {
        private string brand;
        private int myear;
        private string color;
        public car(int vno, string vehicleType, string brand, int myear, string color):base(vno,vehicleType)
        {
            this.brand = brand;
            this.myear = myear;
            this.color = color;
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("--------------------First Derived class details------------------");
            Console.WriteLine("Car brand is : " + brand);
            Console.WriteLine("Car manufactured year is : " + myear);
            Console.WriteLine("Car color is : " + color);
        }
    }
    public class owner : car
    {
        private string name;
        private string location;
        
        public owner(int vno, string vehicleType, string brand, int myear, string color, string name,string location):base(vno, vehicleType,  brand, myear, color)
        {
            this.name = name;
            this.location = location;
        }
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
            Console.Write("Enter Owner : ");
            string name = Console.ReadLine();
            Console.Write("Enter owner location : ");
            string location = Console.ReadLine();
            Console.Write("Enter vehicle no : ");
            int vno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter vehicle type : ");
            string vehicleType = Console.ReadLine();
            Console.Write("Enter car brand name : ");
            string brand = Console.ReadLine();
            Console.Write("Enter car manufactured year : ");
            int myear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter car color : ");
            string color = Console.ReadLine();
            Console.WriteLine("--------------------------------------\n");
            owner o = new owner(vno,vehicleType,brand,myear,color,name,location);
            o.display();

        }
    }
}