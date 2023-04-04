using System;

namespace SealedClass
{
    public class Student
    {
        public void StdInfo(int roll, string name)
        {
            Console.WriteLine($"Roll no is : {roll}\nName is : {name}");
        }
        public virtual void display()
        {
            Console.WriteLine("This is student class ");
        }
    }
     public class Dept : Student
    {
        public  void StdDept(string dept)
        {
            Console.WriteLine("Department is : " + dept);
        }
        public sealed override  void display()
        {
            base.display();
            Console.WriteLine("This is Department class ");
        }
    }
    public class NoOfStudents:Dept
    {
        public override void display()
        {
            base.display();
            Console.WriteLine("This is No Of Students class ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dept d = new Dept();
            Student std = d;
            d.StdInfo(1111, "Ajith");
            d.StdDept("CSE");
            std.StdInfo(2222, "Hari");
            d.display();
            
        }
    }
}