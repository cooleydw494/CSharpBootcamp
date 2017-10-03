using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_46A
{
    class WageEmployee : Employee
    {
        public double Wage { get; set; }
        public double Hours { get; set; }

        public WageEmployee()
        {
        }

        public WageEmployee(string firstName, string lastName, int employeeID, double wage, double hours)
            :base(firstName, lastName, employeeID)
        {
            this.Wage = wage;
            this.Hours = hours;
        }

        public override double Pay()
        {
            return Math.Round(Hours * Wage, 2);
        }

        public override void Talk()
        {
            base.Talk();
            Console.WriteLine("speaking as a wage employee...");
        }
    }
}
