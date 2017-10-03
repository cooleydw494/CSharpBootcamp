using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            doWork();
        }

        static void doWork()
        {
            try
            {
                Triangle tri1 = new Triangle();
                Triangle tri2 = new Triangle(5);
                Triangle tri3 = new Triangle(5, 10);
                Triangle tri4 = new Triangle(5, 10, 15);

                Console.WriteLine("Triangle 1, side 1 is {0} unit{1}",tri1.getSideOne(), tri1.getSideOne() == 1 ? "" : "s");
                Console.WriteLine("Triangle 2, side 1 is {0} unit{1}", tri2.getSideOne(), tri2.getSideOne() == 1 ? "" : "s");
                Console.WriteLine("Triangle 3, side 2 is {0} unit{1}", tri3.getSideTwo(), tri3.getSideTwo() == 1 ? "" : "s");
                Console.WriteLine("Triangle 4, side 3 is {0} unit{1}", tri4.getSideThree(), tri4.getSideThree() == 1 ? "" : "s");

                tri1.setSideOne(50);
                tri2.setSideOne(60);
                tri3.setSideTwo(70);
                tri4.setSideThree(80);

                Console.WriteLine("Triangle 1, side 1 is {0} unit{1}", tri1.getSideOne(), tri1.getSideOne() == 1 ? "" : "s");
                Console.WriteLine("Triangle 2, side 1 is {0} unit{1}", tri2.getSideOne(), tri2.getSideOne() == 1 ? "" : "s");
                Console.WriteLine("Triangle 3, side 2 is {0} unit{1}", tri3.getSideTwo(), tri3.getSideTwo() == 1 ? "" : "s");
                Console.WriteLine("Triangle 4, side 3 is {0} unit{1}", tri4.getSideThree(), tri4.getSideThree() == 1 ? "" : "s");

                int n1 = 8;
                int? n2 = null;
                n1 = (int)n2;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("We're Done!");
            }
        }
    }
}
