using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_46A
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoTests();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("You are all done, exceptions or not!\n");
            }
        }

        static void DoTests()
        {
            WageEmployee bobWage = new WageEmployee("Bob", "Wage", 12345, 10.00, 40.00);
            SalariedEmployee bobSalary = new SalariedEmployee("Bob", "Salary", 12346, 60000.00);

            Console.WriteLine($"{bobWage.FirstName} {bobWage.LastName} is a wage employee with ID {bobWage.EmployeeID}");
            Console.WriteLine($"He makes ${bobWage.Wage} per hour and works {bobWage.Hours} per week");
            Console.WriteLine($"He makes ${bobWage.Pay()} per week");

            Console.WriteLine();

            Console.WriteLine($"{bobSalary.FirstName} {bobSalary.LastName} is a salaried employee with ID {bobSalary.EmployeeID}");
            Console.WriteLine($"He makes ${bobSalary.AnnualSalary} per year");
            Console.WriteLine($"He makes ${bobSalary.Pay()} per week");

            bobWage.addJob("associate");
            bobSalary.addJob("manager");

            Console.WriteLine("\nBob Wage Talks");
            bobWage.Talk();
            Console.WriteLine("\nBob Salary Talks");
            bobSalary.Talk();


            Console.WriteLine($"\n{bobWage.FirstName} {bobWage.LastName} is the {bobWage.selectJob()}");
            Console.WriteLine($"His type is {Person.whatIsIt(bobWage)}");

            Console.WriteLine($"\n{bobSalary.FirstName} {bobSalary.LastName} is the {bobSalary.selectJob()}");
            Console.WriteLine($"His type is {Person.whatIsIt(bobSalary)}");

            Console.WriteLine("\nBob Wage tries to add 'manager' as his job");
            bobWage.addJob("manager");

            Console.WriteLine();
        }
    }
}