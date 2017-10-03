using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoogeAmalgamatedBank;
using BozoNationalBank;

namespace MidtermExtraCredit3
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            IBankAccount saver = new SaverAccount();
            IBankAccount gold = new GoldAccount();

            try
            {
                Console.WriteLine("First count:");
                Console.WriteLine($"Number of Gold Accounts: {GoldAccount.NumOfAccounts}");
                Console.WriteLine($"Number of Saver Accounts: {SaverAccount.NumOfAccounts}");

                IBankAccount saver1 = new SaverAccount();
                IBankAccount gold1 = new GoldAccount();

                Console.WriteLine("Second count:");
                Console.WriteLine($"Number of Gold Accounts: {GoldAccount.NumOfAccounts}");
                Console.WriteLine($"Number of Saver Accounts: {SaverAccount.NumOfAccounts}");

                gold1 = null;
                saver1 = null;

                GC.Collect();

                Console.WriteLine("After null:");
                Console.WriteLine($"Number of Gold Accounts: {GoldAccount.NumOfAccounts}");
                Console.WriteLine($"Number of Saver Accounts: {SaverAccount.NumOfAccounts}");

                saver.Deposit(1250.75M);
                saver.Withdraw(700.50M);

                gold.Deposit(5000.38M);
                gold.Withdraw(5678.90M);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"after withdrawal of $700.50...{saver.ToString()}");
                Console.WriteLine($"after (failed)withdrawal of $5678.90...{gold.ToString()}");
            }
        }
    }
}