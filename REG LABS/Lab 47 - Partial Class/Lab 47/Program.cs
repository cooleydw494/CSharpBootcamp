using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc1 = new Calculator();
            Console.WriteLine($"X = {calc1.Int1} Y = {calc1.Int2}");

            Calculator calc2 = new Calculator(5, 10);
            Console.WriteLine($"X = {calc2.Int1} Y = {calc2.Int2}");

            Console.WriteLine($"Sum Result: {calc1.CalculateSum()}");
            Console.WriteLine($"Product Result: {calc1.CalculateProduct()}");

            Console.WriteLine($"Sum Result: {calc2.CalculateSum()}");
            Console.WriteLine($"Product Result: {calc2.CalculateProduct()}");
        }
    }
}