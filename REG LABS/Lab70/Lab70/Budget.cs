using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab70
{
    class Budget
    {
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }

        public Budget()
        {

        }
        public Budget(decimal revenue, decimal expenses)
        {
            Revenue = revenue;
            Expenses = expenses;
        }

        public static bool operator true(Budget b)
        {
            if (b.Revenue == 0 && b.Expenses == 0)
            {
                return false;
            }
            else return true;
        }
        public static bool operator false(Budget b)
        {
            return false;
        }
        public static Budget operator +(Budget lhs, Budget rhs)
        {
            return new Budget(lhs.Revenue + rhs.Revenue, lhs.Expenses + rhs.Expenses);
        }
        
        public void PrintBudget(string m)
        {
            Console.WriteLine($"{m}\nRevenue: {Revenue:C}\nExpenses: {Expenses:C}\n");
        }
    }
}
