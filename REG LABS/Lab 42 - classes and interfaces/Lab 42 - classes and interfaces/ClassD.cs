using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_42
{
    class ClassD : ClassA
    {
        public override void printString(string message)
        {
            base.printString($"{message} (from class A)");
            Console.WriteLine(message);
        }
    }
}