using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit1
{
    class GoldAccount : IBankAccount
    {
        public decimal Balance { get; set; }

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
