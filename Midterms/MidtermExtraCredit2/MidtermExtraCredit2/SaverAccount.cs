using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidtermExtraCredit2;

namespace BozoNationalBank
{
    class SaverAccount : IBankAccount
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
                Console.WriteLine("Cannot Withdraw Due to Insufficient Funds...");
                return false;
            }
        }

        public override string ToString()
        {
            return String.Format("Saver Account: Balance = {0:C}", Balance);
        }
    }
}
