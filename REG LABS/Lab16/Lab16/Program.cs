using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());

            bool isLessThan10 = (userInput < 10);
            bool isBetween0and5 = (userInput >= 0 && userInput <= 5);
            bool isOneOfTwo = (isLessThan10 ^ isBetween0and5);

            Console.WriteLine("Integer less than 10? {0}", isLessThan10);
            Console.WriteLine("Integer between 0 and 5? {0}", isBetween0and5);
            Console.WriteLine("Exactly one of the above is true? {0}", isOneOfTwo);


        }
    }
}
