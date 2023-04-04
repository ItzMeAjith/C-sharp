using System;

namespace AbstractClass
{
    public abstract class Student
    {
        public void StdInfo(int roll,string name)
        {
            Console.WriteLine($"Roll no is : {roll}\nName is : {name}");
        }
        public abstract void StdDept(string dept);
    }
    public class Dept:Student
    {
        public override void StdDept(string dept)
        {
            Console.WriteLine("Department is : " + dept);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dept d= new Dept();
            Student std = d;
            d.StdInfo(1111, "Ajith");
            d.StdDept("CSE");
            std.StdDept("IT");
        }
    }
}