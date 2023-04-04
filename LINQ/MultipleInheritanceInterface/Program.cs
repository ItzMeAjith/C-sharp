using System;

namespace MultipleInheritanceInterface
{
    abstract class Project1
    {
        public abstract string progress1();
    }
    interface Iproject
    {
        string progress();
    }

    class UI : Project1,Iproject
    {
        public string progress()
        {
            return "Completed UI";
        }
        public override string progress1()
        {
            return "Method inside abstract class";
        }
    }
    class DBdesign : Project1, Iproject
    {
        public string progress()
        {
            return "Completed DB design";
        }
        public override string progress1()
        {
            return "Method inside abstract class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the status : ");
            string status = Console.ReadLine();
             UI u= new UI();
             DBdesign d= new DBdesign();
            //Iproject u = new UI();
            //Iproject d = new DBdesign();
            if (status == "UI")
                Console.WriteLine(u.progress()+"\n"+u.progress1());
            else if (status == "DBdesign")
                Console.WriteLine(d.progress()+"\n"+d.progress1());
            else
                Console.WriteLine("Enter the valid status");
        }
    }
}