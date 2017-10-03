using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception Thrown: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block has been reached\n");
            }
        }

        static void doWork()
        {
            Checker testChecker = new Checker();

            ClassA test1 = new ClassA();
            ClassB test2 = new ClassB();
            ClassC test3 = new ClassC();
            ClassD test4 = new ClassD();
            ClassF test5 = new ClassF();
            ClassG test6 = new ClassG();

            MyStruct test7 = new MyStruct();

            testChecker.Check(test1);
            testChecker.Check(test2);
            testChecker.Check(test3);
            testChecker.Check(test4);
            testChecker.Check(test5);
            testChecker.Check(test6);
            testChecker.Check(test7);

            throw new Exception("Generic Fake Exception for Testing Purposes!\n");
        }
    }
}