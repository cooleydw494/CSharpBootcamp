using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_46A
{
    class SalariedEmployee : Employee, IManager
    {
        public double AnnualSalary { get; set; }

        public SalariedEmployee()
        {
        }
        
        public SalariedEmployee(string firstName, string lastName, int employeeID, double annualSalary)
            :base(firstName, lastName, employeeID)
        {
            this.AnnualSalary = annualSalary;
        }

        public override double Pay()
        {
            return Math.Round(AnnualSalary / 52.2, 2);
        }

        public override void Talk()
        {
            if (selectJob() == "manager")
            {
                Speak();
            }
            else
            {
                base.Talk();
            }
        }

        public string Speak()
        {
            Console.WriteLine("speaking as a manager");
            return "speaking as a manager";
        }
    }
}
