using System;

namespace File_Handling
{
    internal class Program
    {
        public static string oddEven(int n)
        {
            if(n%2==0)
            {
                return "This is a even number";
            }
            else
            {
                return "This is a odd number";
            }
        }
        public static string prime(int n)
        {
            int flag = 0;
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                { 
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                return "This is a prime number";
            else
                return "This is a not a prime number";
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            using (FileStream fs=new FileStream(@"D:\Log.txt",FileMode.Append))
            {
                using (StreamWriter stw = new StreamWriter(fs))
                {
                    stw.WriteLine("The number you have entered is : " + n);
                    stw.WriteLine(oddEven(n));
                    stw.WriteLine(prime(n));
                    stw.WriteLine("------------------------------------------------------");
                    stw.Flush();
                }
            }
            using (FileStream fs1 = new FileStream(@"D:\Log.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs1))
                {
                    string cont = sr.ReadToEnd();
                    Console.WriteLine(cont);
                }
            }
            Console.WriteLine("Informations entred successfully..........");
        }
    }
}