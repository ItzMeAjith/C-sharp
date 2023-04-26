using System;

namespace Assembly // Note: actual namespace depends on the project name.
{
   /* public class IT
    {
        public string rollno="71051907002";
        public string name="Ajith";
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 t=new Class1();
            Console.WriteLine("Roll no is {0} \nName is {1}",t.rollno,t.name);
        }
    }
}