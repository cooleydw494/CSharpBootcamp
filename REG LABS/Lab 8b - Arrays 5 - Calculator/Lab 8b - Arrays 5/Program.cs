using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        private static double operand1, operand2;
        private static char operator1;
        private static string[] calcSeperated;
        private static string calculation;

        static void Main(string[] args)
        {

            Console.WriteLine("This is a basic calculator\nEnter 1 operand, operator, and another operand\nSeperate by spaces ie) 5 * 6\n");

            while (true)
            {
                try
                {
                    calculation = Console.ReadLine();
                    calcSeperated = calculation.Split(' ');
                    operand1 = Convert.ToDouble(calcSeperated[0]);
                    operator1 = Convert.ToChar(calcSeperated[1]);
                    operand2 = Convert.ToDouble(calcSeperated[2]);
                    Calculate();
                }

                catch (FormatException fEx)
                {
                    Console.WriteLine("\n{0}", fEx.Message);
                    Console.WriteLine("\n:P Make sure you are only using numbers as operands :P\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine(":D Calculator Reset :D\n");
                }
            }

        }

        static void Calculate()
        {
            switch (operator1)
            {
                case '+':
                    Console.WriteLine("\nthe sum of {0} and {1} is {2}\n", operand1, operand2, operand1 + operand2);
                    break;
                case '-':
                    Console.WriteLine("\nthe difference of {0} and {1} is {2}\n", operand1, operand2, operand1 - operand2);
                    break;
                case '*':
                    Console.WriteLine("\nthe product of {0} and {1} is {2}\n", operand1, operand2, operand1 * operand2);
                    break;
                case '/':
                    Console.WriteLine("\nthe quotient of {0} and {1} is {2}\n", operand1, operand2, operand1 / operand2);
                    break;
                default:
                    throw new Exception("\n:( Invalid Operator :(\n");
            }
        }
    }
}
