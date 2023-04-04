using System;

namespace Inheritance
{ 
    interface Iproject
    {
        string progress();
    }
    class UI:Iproject
    {
        public string progress()
        {
            return "Completed UI";
        }
    }
    class DBdesign : Iproject
    {
        public string progress()
        {
            return "Completed DB design";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the status : ");
            string status=Console.ReadLine();
           // UI u= new UI();
            //DBdesign d= new DBdesign();
            Iproject u=new UI();
            Iproject d = new DBdesign();
            if (status == "UI")
                Console.WriteLine(u.progress());
            else if (status == "DBdesign")
                Console.WriteLine(d.progress());
            else
                Console.WriteLine("Enter the valid status");
        }
    }
}