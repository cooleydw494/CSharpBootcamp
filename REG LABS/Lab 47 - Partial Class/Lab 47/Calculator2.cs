using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_47
{
    public sealed partial class Calculator
    {
        public int CalculateSum()
        {
            return Int1 + Int2;
        }
        public int CalculateProduct()
        {
            return Int1 * Int2;
        }
    }
}
