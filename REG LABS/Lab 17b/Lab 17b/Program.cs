using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17b
{
    class Program
    {
        static void Main(string[] args)
        {
            byte direction;
            double distance;
            Route route;

            Console.WriteLine("1) {0}", Orientation.North);
            Console.WriteLine("2) {0}", Orientation.South);
            Console.WriteLine("3) {0}", Orientation.East);
            Console.WriteLine("4) {0}", Orientation.West);

            Console.WriteLine("Select a direction");
            direction = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Select a distance");
            distance = Convert.ToDouble(Console.ReadLine());

            route.direction = (Orientation)direction;
            route.distance = distance;

            Console.WriteLine("My Route specifies a direction of {0} and a distance of {1}", route.direction, route.distance);
        }
    }
}
