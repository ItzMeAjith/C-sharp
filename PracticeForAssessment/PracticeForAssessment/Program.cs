using System;
using System.Collections;

namespace PracticeForAssessment
{
    internal class Program
    {
       /* class msgException:Exception
        {
            public msgException(string msg):base(msg)
            {
                
            }
        }*/
        static void Main(string[] args)
        {
            /*int age = 10;

            try
            {
                if (age < 20)
                {
                    throw new Exception("Age should be greater than 20");
                }
                else Console.WriteLine("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            using(FileStream fs=new FileStream(@"D:\Internship\Training\SQL\resources\Ajith.txt", FileMode.OpenOrCreate))
            {
                using(StreamWriter sw=new StreamWriter(fs))
                {
                    sw.WriteLine("Ajith loves Sujiiii");
                }
            }*/
            string op, name;
            int roll;
            ArrayList Std = new ArrayList();
            do
            {
                Console.Write("Enter Roll no : ");
                roll = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter name : ");
                name = Console.ReadLine();
                Std.Add(roll);
                Std.Add(name);
                Console.Write("Do you want to insert another recored (yes/no) : ");
                op = Console.ReadLine();
            } while (op == "yes");
            Console.WriteLine("Students list is : ");
            foreach (object i in Std)
            {
                Console.Write(i + " ");
            }
        }
    }
}