using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Layout layout1 = new Layout();

            layout1[1] = "Frank Gehry";
            layout1[3] = "I. M. Pei";
            layout1[10] = "Frank Lloyd Wright";
            layout1[11] = "Apollodorus of Damascus";
            layout1[-1] = "Error";
            layout1[1000] = "Error";

            Console.WriteLine(layout1[1]);
            Console.WriteLine(layout1[3]);
            Console.WriteLine(layout1[10]);
            Console.WriteLine(layout1[11]);
            Console.WriteLine(layout1[-1]);
            Console.WriteLine(layout1[1000]);
        }
    }
}