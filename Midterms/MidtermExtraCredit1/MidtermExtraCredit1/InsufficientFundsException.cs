using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit1
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException()
            :base()
        {}

        public InsufficientFundsException(string message)
            :base(message)
        {
            Console.WriteLine("Withdrawal attempt failed. Make a deposit first");
        }
    }
}
