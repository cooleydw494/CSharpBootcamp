using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab01
{
    class GrandChild : Child
    {
        public GrandChild()
            :base()
        {
            Console.WriteLine("GrandChild Default Constructor");
        }
        public GrandChild(string message)
            :base(message)
        {
            Console.WriteLine("GrandChild String Constructor");
            Console.WriteLine($"Message: {message}");
        }
        public override void print(string message)
        {
            base.print(message);
            Console.WriteLine($"{message} from GrandChild");
        }
    }
}
