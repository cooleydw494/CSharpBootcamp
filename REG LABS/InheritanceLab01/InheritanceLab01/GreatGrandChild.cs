using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab01
{
    class GreatGrandChild : GrandChild
    {
        public GreatGrandChild()
            :base()
        {
            Console.WriteLine("GreatGrandChild Default Constructor");
        }
        public GreatGrandChild(string message)
            :base(message)
        {
            Console.WriteLine("GreatGrandChild String Constructor");
            Console.WriteLine($"Message: {message}");
        }
        public override void print(string message)
        {
            base.print(message);
            Console.WriteLine($"{message} from GreatGrandChild");
        }
    }
}
