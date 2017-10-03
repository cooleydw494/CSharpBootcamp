using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_47
{
    public sealed partial class Calculator
    {
        public int Int1 { get; set;}
        public int Int2 { get; set; }

        public Calculator()
        {
        }

        public Calculator(int int1, int int2)
        {
            Int1 = int1;
            Int2 = int2;
        }
    }
}
