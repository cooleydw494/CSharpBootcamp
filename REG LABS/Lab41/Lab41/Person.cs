using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab41
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name = "NoName")
        {
            Name = name;
        }
        public void Say(string message)
        {
            Console.WriteLine($"{Name} says: {message}");
        }
    }
}
