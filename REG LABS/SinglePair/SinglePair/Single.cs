using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePair
{
    class Single
    {
        public string Name { get; set; }

        public Single(string name = "Default")
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
        
        public static Pair operator + (Single one, Single two)
        {
            return new Pair(one, two);
        }
    }
}
