using System;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the statement to be reversed : ");
            string s=Console.ReadLine();
            Console.Write("The statement after reversed is : ");

            int f = 0,p=0,l=0;
            l = s.Length - 1;
            for (int i=s.Length-1;i>=0;i--)
            {
                if(i==0)
                {
                    f = 0;

                }
                if (s[i]==' ')
                {
                    f = i + 1;
                    for (int j=f;j<=l;j++)
                    {
                        Console.Write(s[j]);
                    }
                    Console.Write(" ");
                    l = i-1;
                }
            }
        }
    }
}