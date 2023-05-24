using Microsoft.VisualBasic.FileIO;
using System;
using System.Net;
using System.Xml.Linq;

namespace Pay_Insurance
{
    internal class Program
    {
        public static double addPolicy(int option,Insurance Ins)
        {
           
                double prim = 0;
                if (option == 1)
                {
                    LifeInsurance lifeInsurance = (LifeInsurance)Ins;
                    prim = lifeInsurance.calculatePremium();
                }
                else if (option == 2)
                {
                MotorInsurance motorInsurance = (MotorInsurance)Ins;
                prim = motorInsurance.calculatePremium();

                }
                else
                {
                    Console.WriteLine("Invalid option!!!");
                }
                return prim;
            
            
        }
        static void Main(string[] args)
        {
            try
            {
                
                Console.Write("Enter the insurance number : ");
                string InsuranceNumber = Console.ReadLine();
                Console.Write("Enter the insurance name : ");
                string InsuranceName = Console.ReadLine();
                Console.Write("Enter the amount covered : ");
                double AmountCovered = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the option : \n1.Life Insurance\n2.Motor Insurance");
                int option = Convert.ToInt32(Console.ReadLine());
              


                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("------------------LIFE INSURANCE ---------------------------- ");
                            //LifeInsurance Lins = new LifeInsurance();
                            Console.Write("Enter the Policy term : ");
                            int PolicyTerm = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the Benefit percentage : ");
                            float BenefitPercent = (float)Convert.ToDouble(Console.ReadLine());
                            LifeInsurance Lins = new LifeInsurance()
                            {
                                InsuranceName=InsuranceName,
                                InsuranceNumber=InsuranceNumber,
                                AmountCovered=AmountCovered,
                                PolicyTerm=PolicyTerm,
                                BenefitPercent=BenefitPercent
                            };
                            Console.WriteLine("Calculated Premium is : " + addPolicy(option, Lins));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("-------------------MOTOR INSURANCE ---------------------------");
                           // MotorInsurance Mins = new MotorInsurance();
                            Console.Write("Enter the Depreciation percentage : ");
                            double DepPercent = Convert.ToDouble(Console.ReadLine());
                            MotorInsurance Mins = new MotorInsurance()
                            {
                                InsuranceNumber=InsuranceNumber,
                                InsuranceName = InsuranceName,
                                AmountCovered=AmountCovered,
                                DepPercent=DepPercent
                            };
                            Console.WriteLine("Calculated Premium is : " + addPolicy(option, Mins));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter the valid option !!!!!!");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : "+ex.Message);
            }


        }
    }
}