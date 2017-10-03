using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoogeAmalgamatedBank;
using BozoNationalBank;

namespace MidtermExtraCredit2
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            IBankAccount saver = new SaverAccount();
            IBankAccount gold = new GoldAccount();

            try
            {
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
