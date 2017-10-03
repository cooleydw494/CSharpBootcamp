using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidtermExtraCredit3;

namespace StoogeAmalgamatedBank
{
    class GoldAccount : IBankAccount
    {
        internal static int NumOfAccounts { get; set; }
        public decimal Balance { get; set; }

        public GoldAccount()
        {
            NumOfAccounts++;
        }
        ~GoldAccount()
        {
            NumOfAccounts--;
            Console.WriteLine($"Number of Gold Accounts: {GoldAccount.NumOfAccounts}");
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                throw new InsufficientFundsException($"throwing InsufficientFundsException on {this.GetType().Name}");
            }
        }

        public override string ToString()
        {
            return string.Format("Gold Account: Balance = {0:C}", Balance);
        }
    }
}
