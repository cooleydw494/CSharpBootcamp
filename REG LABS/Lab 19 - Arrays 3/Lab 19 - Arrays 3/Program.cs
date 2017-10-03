using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_19___Arrays_3
{
    class Program
    {
        private static string myString = "This is a test.";
        private static char[] separator = { ' ' };
        private static string[] myWords;

        static void Main(string[] args)
        {

            myWords = myString.Split(separator);

            foreach (string myWord in myWords)
            {
                Console.WriteLine(myWord);
            }
        }
    }
}
