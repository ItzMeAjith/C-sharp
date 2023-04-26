using System;
namespace Day1 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Result");
            Result r1 = new Result();
           // r1.Name = "Ajith";
            //r1.Dept = "IT";
            r1.Marks();
            r1.total();
        }
    }
    class Result
    {
        public String Name;
        public String Dept;
        int m1, m2, m3, m4, m5;
        public void Marks()
        {
            Console.Write("Enter your name:");
            Name = Console.ReadLine();
            Console.Write("Enter your department :");
            Dept = Console.ReadLine();
            Console.Write("Enter the mark of Subject 1 :");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the mark of Subject 2 :");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the mark of Subject 3 :");
            m3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the mark of Subject 4 :");
            m4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the mark of Subject 5 :");
            m5 = Convert.ToInt32(Console.ReadLine());
        }
        public void total()
        {
            int tot;
            tot = m1 + m2 + m3 + m4 + m5;
            float avg = (float)tot / 500*100;
            Console.WriteLine("Your Aggregate percentage is :" + avg + "%");
            if(avg>=90)
            {
                Console.WriteLine("Your Grade is O");
            }
            else if(avg>=80 && avg<90)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if (avg >= 70 && avg < 80)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (avg >= 60 && avg < 70)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (avg >= 50 && avg < 60)
            {
                Console.WriteLine("Your Grade is D");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}