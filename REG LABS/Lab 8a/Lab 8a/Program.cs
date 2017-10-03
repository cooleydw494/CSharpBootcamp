using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static double operand1, operand2;
        static char operator1;

        static void Main(string[] args)
        {

            Console.WriteLine("This is a 3 step basic calculator\n");

            while (true)
            {
                try
                {
                    Console.WriteLine("enter your first operand");
                    operand1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nenter your operator");
                    operator1 = Convert.ToChar(Console.ReadLine());

                    Console.WriteLine("\nenter your second operand");
                    operand2 = Convert.ToDouble(Console.ReadLine());

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
                    Console.WriteLine("\nthe difference of {0} and {1} is {2}\n",operand1, operand2, operand1 - operand2);
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
