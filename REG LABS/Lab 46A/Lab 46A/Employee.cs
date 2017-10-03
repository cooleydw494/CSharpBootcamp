using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_46A
{
    abstract class Employee : Person
    {
        public int EmployeeID { get; set; }
        private string Job { get; set; }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, int employeeID)
            :base(firstName, lastName)
        {
            this.EmployeeID = employeeID;
        }

        public abstract double Pay();

        public override void Talk()
        {
            base.Talk();
            Console.WriteLine("speaking as an employee...");
        }

        public void addJob(string addedJob)
        {
            if (this is WageEmployee && addedJob == "manager")
            {
                throw new Exception("You are a lowly wage employee, you may not become a manager!");
            }
            else
            {
                Job = addedJob;
            }
        }

        public string selectJob()
        {
            return Job;
        }
    }
}
