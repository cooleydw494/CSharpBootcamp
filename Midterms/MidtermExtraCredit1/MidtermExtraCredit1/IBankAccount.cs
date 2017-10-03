using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit1
{
    interface IBankAccount
    {
        Decimal Balance { get; }
        void Deposit (Decimal amount);
        bool Withdraw(Decimal amount);
    }
}
