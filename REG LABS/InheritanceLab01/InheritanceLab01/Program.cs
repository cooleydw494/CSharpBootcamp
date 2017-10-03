using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab01
{
    class Program
    {
        static void Main(string[] args)
        {

            Parent parent1 = new Parent();
            Parent parent2 = new Parent("Stringy Parent");
            parent2.print("hey y'all...");
            Console.WriteLine();

            Child child1 = new Child();
            Child child2 = new Child("Stringy Child");
            child2.print("hey y'all...");
            Console.WriteLine();

            GrandChild gc1 = new GrandChild();
            GrandChild gc2 = new GrandChild("Stringy GrandChild");
            gc2.print("hey y'all...");
            Console.WriteLine();

            GreatGrandChild ggc1 = new GreatGrandChild();
            GreatGrandChild ggc2 = new GreatGrandChild("Stringy GreatGrandChild");
            ggc2.print("hey y'all...");

        }
    }
}
