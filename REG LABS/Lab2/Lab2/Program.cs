using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static double balance, baseBalance, interest, targetBalance;
        static int years;

        static void Main(string[] args)
        {
            Console.WriteLine("What is your current balance?");
            baseBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in percent %)?");
            interest = 1 + (Convert.ToDouble(Console.ReadLine()) / 100);
            Console.WriteLine("What is your desired balance?");
            targetBalance = Convert.ToDouble(Console.ReadLine());

            //for loop calculation
            years = 0;
            for (balance = baseBalance; balance < targetBalance; balance *= interest)
            {
                years++;
            }
            writeResult("For");

            //while loop
            years = 0;
            balance = baseBalance;
            while(balance < targetBalance)
            {
                balance *= interest;
                years++;
            }
            writeResult("While");

            //do loop
            years = 0;
            balance = baseBalance;
            do
            {
                if (balance >= targetBalance)
                {
                    Console.WriteLine("To be honest, you really didn't need this calculator\n");
                }
                else
                {
                    balance *= interest;
                    years++;
                }
            } while (balance < targetBalance);
            writeResult("Do");
        }

        public static void writeResult(string loopType)
        {
            Console.WriteLine("Using {0} Loop:", loopType);
            if (years == 0)
            {
                Console.WriteLine("To be honest, you really didn't need this calculator\n");
            }
            else
            {
                Console.WriteLine("It will take {0} year{1} and you'll have a balance of {2}.\n", years, years == 1 ? "" : "s", balance);
            }
        }
    }
}
