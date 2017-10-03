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

            Console.WriteLine("This is a 3 step basic calculator");

            while (true)
            {
                Console.WriteLine("enter your first operand");
                operand1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter your operator");
                operator1 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("enter your second operand");
                operand2 = Convert.ToDouble(Console.ReadLine());

                Calculate(operand1, operator1, operand2);
            }

        }

        static void Calculate(double operand1, char operator1, double operand2)
        {
            if (operator1 == '+' || operator1 == '-' || operator1 == '*' || operator1 == '/')
            {
                switch (operator1)
                {
                    case '+':
                        Console.WriteLine("the sum is {0}\n", operand1 + operand2);
                        break;
                    case '-':
                        Console.WriteLine("the difference is {0}\n", operand1 - operand2);
                        break;
                    case '*':
                        Console.WriteLine("the product is {0}\n", operand1 * operand2);
                        break;
                    case '/':
                        Console.WriteLine("the quotient is {0}\n", operand1 / operand2);
                        break;
                    default:
                        Console.WriteLine("you've done something wrong and somehow gotten through the operator if statement and fallen through the switch!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("{0} is not a proper operator\nPlease use a legitimate operator +, -, *, / \n", operator1);
            }
        }
    }
}
