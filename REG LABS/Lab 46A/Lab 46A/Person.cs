using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_46A
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
        }
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual void Talk()
        {
            Console.WriteLine("speaking as a Person...");
        }

        public static Type whatIsIt(Person p)
        {
            return p.GetType();
        }
    }
}
