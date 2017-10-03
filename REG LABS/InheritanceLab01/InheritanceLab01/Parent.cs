using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab01
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Default Constructor");
        }
        public Parent(string message)
        {
            Console.WriteLine("Parent String Constructor");
            Console.WriteLine($"Message: { message}");
        }

        public virtual void print(string message)
        {
            Console.WriteLine($"{message} from Parent");
        }
    }
}
