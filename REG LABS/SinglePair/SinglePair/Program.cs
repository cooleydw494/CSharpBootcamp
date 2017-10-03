using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePair
{
    class Program
    {
        static void Main(string[] args)
        {
            Single bill = new Single("Bill");
            Single charlie = new Single("Charlie");

            Console.WriteLine($"{bill.GetType().Name}: {bill.ToString()}");
            Console.WriteLine($"{charlie.GetType().Name}: {charlie.ToString()}");

            Pair billncharlie = bill + charlie; // overloaded Single + operator to return a pair made up of Singles

            Console.WriteLine($"{billncharlie.GetType().Name}: {billncharlie.ToString()}");
        }
    }
}
