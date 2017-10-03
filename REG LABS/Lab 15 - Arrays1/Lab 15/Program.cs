using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    class Program
    {
        private static int[] ints = { 0, 1, 3, 5, 7 };
        private static int i = 1;

        static void Main(string[] args)
        {
            Console.WriteLine($"The first value stored in the array is {ints[0]}");
            Console.WriteLine($"The value of the i variable is {i}");
            Console.WriteLine("Ready to call the method!");

            Method(ints, i);

            Console.WriteLine("Ran the method!");

            Console.WriteLine($"\nThe first value stored in the array is now {ints[0]}");
            Console.WriteLine($"The value of the i variable is now {i}");
        }

        static void Method(int[] intArr, int intVal)
        {
            intArr[0] = 100;
            intVal = 10;
        }
    }
}
