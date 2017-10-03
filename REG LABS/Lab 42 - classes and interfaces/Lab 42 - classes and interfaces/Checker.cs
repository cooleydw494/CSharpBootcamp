using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_42
{
    class Checker
    {
        public void Check(object obj)
        {
            Console.WriteLine($"Analyzing {obj.GetType()} type variable:");
            
            //can obj be converted to ClassA?
            if (obj is ClassA)
            {
                Console.WriteLine("Variable CAN be converted to ClassA.");
            }
            else
            {
                Console.WriteLine("Variable CAN'T be converted to ClassA");
            }

            //can obj be converted to ClassB?
            if (obj is ClassB)
            {
                Console.WriteLine("Variable CAN be converted to ClassB.");
            }
            else
            {
                Console.WriteLine("Variable CAN'T be converted to ClassB");
            }

            //can obj be converted to ClassC?
            if (obj is ClassC)
            {
                Console.WriteLine("Variable CAN be converted to ClassC.");
            }
            else
            {
                Console.WriteLine("Variable CAN'T be converted to ClassC");
            }

            //can obj be converted to ClassD?
            if (obj is ClassD)
            {
                Console.WriteLine("Variable CAN be converted to ClassD.");
            }
            else
            {
                Console.WriteLine("Variable CAN'T be converted to ClassD");
            }

            //can obj be converted to MyStruct?
            if (obj is MyStruct)
            {
                Console.WriteLine("Variable CAN be converted to MyStruct.");
            }
            else
            {
                Console.WriteLine("Variable CAN'T be converted to MyStruct");
            }

            //can obj be converted to IMyInterface?
            if (obj is IMyInterface)
            {
                Console.WriteLine("Variable CAN be converted to IMyInterface.");
            }
            else
            {
                Console.WriteLine("Variable CAN'T be converted to IMyInterface");
            }
            //can obj be converted to ClassE?
            if (obj is ClassE)
            {
                Console.WriteLine("Variable CAN be converted to ClassE.");
            }
            else
            {
                Console.WriteLine("Variable CAN'T be converted to ClassE");
            }
            //can obj be converted to ClassF?
            if (obj is ClassF)
            {
                Console.WriteLine("Variable CAN be converted to ClassF.");
            }
            else
            {
                Console.WriteLine("Variable CAN'T be converted to ClassF");
            }
            //can obj be converted to ClassG?
            if (obj is ClassG)
            {
                Console.WriteLine("Variable CAN be converted to ClassG.");
            }
            else
            {
                Console.WriteLine("Variable CAN'T be converted to ClassG");
            }

            //test printString
            if (obj is IMyInterface)
            {
                IMyInterface interfaceObj = (IMyInterface)obj;
                interfaceObj.printString($"Hello from class {obj.GetType()}");
            }

            //test Howdy
            if (obj is ClassE)
            {
                ClassE e = (ClassE)obj;
                e.Howdy($"Howdy from {e.GetType()}");
            }
            Console.WriteLine();
        }
    }
}