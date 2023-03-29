using System;

namespace GetandSet
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private string dept;
        
        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age;} set { age = value; } }
        public string Dept { get { return dept; } set { dept = value; } }

        public void diplay()
        {
            Console.WriteLine($"ID is : {id}\nName is : {name}\nAge is : {age}\nDepartment is : {dept}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s= new Student();
            s.ID= 1;
            s.Name = "Ajith";
            s.Age = 30;
            s.Dept = "IT";
            s.diplay();
        }
    }
}