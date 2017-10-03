using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18___Arrays_2
{
    class Program
    {
        private static string[] friendNames = { "Moe", "Larry", "Curly" };

        static void Main(string[] args)
        {
            Console.WriteLine($"Here are {friendNames.Length} of my friends");

            Console.WriteLine("\nTheir names are");
            for (int i = 0; i < friendNames.Length; i++)
            {
                Console.WriteLine(friendNames[i]);
            }

            Console.WriteLine("\nIf you didn't hear me, I said...");
            foreach (string friendName in friendNames)
            {
                Console.WriteLine(friendName);
            }
        }
    }
}
