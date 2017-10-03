using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_42
{
    struct MyStruct : IMyInterface
    {
        public void printString(string message)
        {
            Console.WriteLine(message);
        }
    }
}