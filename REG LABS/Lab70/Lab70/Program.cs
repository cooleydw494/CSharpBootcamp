using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab70
{
    class Program
    {
        static void Main(string[] args)
        {
            Budget retail = new Budget(1043000.00m, 102030.00m);
            Budget online = new Budget(2043000.00m, 202030.00m);

            retail.PrintBudget("Retail Budget:");
            online.PrintBudget("Online Budget:");

            (retail + online).PrintBudget("Retail and Online Budgets Combined:");

            Budget empty = new Budget();
            if (empty)
            {
                empty.PrintBudget("Empty Budget:");
            }
            else
            {
                Console.WriteLine("Empty Budget is Empty");
            }

        }
    }
}
