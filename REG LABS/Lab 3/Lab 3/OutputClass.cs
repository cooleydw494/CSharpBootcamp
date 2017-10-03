using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class OutputClass
    {
        private string myString;

        //default constructor
        public OutputClass()
        {
            myString = "Nobody told me what to say";
        }

        //constructor that takes a string
        public OutputClass(string myString)
        {
            this.myString = myString;
        }

        //method that WriteLines the myString variable
        public void printString()
        {
            Console.WriteLine("{0}\n", myString);
        }
    }
}
