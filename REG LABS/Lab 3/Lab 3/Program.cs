using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputClass example1 = new OutputClass("This is printed by the OutputClass");
            example1.printString();

            OutputClass example2 = new OutputClass("Here is my second string printed by my example2 instance");
            example2.printString();

            OutputClass example3 = new OutputClass("And a third string just to kind of make sure");
            example3.printString();

            OutputClass example4 = new OutputClass();
            example4.printString();
        }
    }
}
