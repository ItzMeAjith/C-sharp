/*4. Write a C program to input basic salary of an employee and calculate gross salary according
to given conditions.
Basic Salary <= 10000 : HRA = 20 %, DA = 80 %
Basic Salary is between 10001 to 20000 : HRA = 25 %, DA = 90 %
Basic Salary >= 20001 : HRA = 30 %, DA = 95 %
Note: da = basic * DA
hra = basic * HRA
gross_salary = basic_salary + da + hra */

using Day1;
using System;
namespace Day1
{
    class Salary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the basic salary : ");
            int salary =int.Parse( Console.ReadLine());
            float gsalary;
            float HRA, DA,da,hra;
            if(salary <= 10000)
            {
                HRA =(float)20 / 100;
                DA= (float)80 / 100;
            }
            else if(salary>=10001 && salary<=20000)
            {
                HRA = (float)30 / 100;
                DA = (float)95 / 100;
            }
            else
            {
                HRA = (float)25 / 100;
                DA = (float)90 / 100;
            }
            da = salary * DA;
            hra = salary * HRA;
            gsalary = salary + da + hra;
            //Console.WriteLine(da);
            //Console.WriteLine(hra);
            Console.WriteLine("The Gross salary is : " + gsalary);
        }
    }
}





/*

if (salary >= 10001 && salary <= 20000)
{
    gsalary = (float)(salary + (salary * 25 / 100) + (salary * 90 / 100));
}
else if (salary <= 10000)
{
    gsalary = (float)(salary + (salary * 20 / 100) + (salary * 80 / 100));
}
else
{
    gsalary = (float)(salary + (salary * 30 / 100) + (salary * 95 / 100));
}
Console.WriteLine("The Gross salary is : " + gsalary);*/