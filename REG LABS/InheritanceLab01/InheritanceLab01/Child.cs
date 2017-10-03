using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab01
{
    class Child : Parent
    {
        public Child()
            :base()
        {
            Console.WriteLine("Child Default Constuctor");
        }
        public Child(string message)
            :base(message)
        {
            Console.WriteLine("Child String Constructor");
            Console.WriteLine($"Message: {message}");
        }
        public override void print(string message)
        {
            base.print(message);
            Console.WriteLine($"{message} from Child");
        }
    }
}
