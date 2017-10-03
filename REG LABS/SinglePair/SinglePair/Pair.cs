using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePair
{
    class Pair
    {
        public Single One { get; set; }
        public Single Two { get; set; }

        public Pair()
        {
            One = new Single("default");
            Two = new Single("default");
        }

        public Pair(Single one, Single two)
        {
            One = one;
            Two = two;
        }

        public override string ToString()
        {
            return $"{One.ToString()} and {Two.ToString()}";
        }
    }
}
