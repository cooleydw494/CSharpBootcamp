using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            IBankAccount saver = new SaverAccount();
            IBankAccount gold = new GoldAccount();

            saver.Deposit(1250.75M);
            Console.WriteLine($"after deposit...{saver.ToString()}");
            saver.Withdraw(700.50M);
            Console.WriteLine($"after withdrawal of $700.50...{saver.ToString()}");

            gold.Deposit(5000.38M);
            Console.WriteLine($"after deposit...{gold.ToString()}");
            gold.Withdraw(5678.90M);
            Console.WriteLine($"after (failed)withdrawal of $5678.90...{gold.ToString()}");

        }
    }
}
