using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    interface IBankAccount
    {
        decimal Balance { get; }
        void Deposit (decimal amount);
        bool Withdraw (decimal amount);
    }
}
