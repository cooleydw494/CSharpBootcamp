using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_23___params_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9 };
            int[] maxValIndices;

            Console.WriteLine($"Maximum Value {Maxima(testArray, out maxValIndices)} found at indices:");
            foreach(int maxValIndex in maxValIndices)
            {
                Console.WriteLine(maxValIndex);
            }
        }

        public static int Maxima(int[] testArr, out int[] maxValArr)
        {
            Console.WriteLine("Maximum value search started...");

            int maxVal = testArr[0];
            int maxValCount = 0;

            Console.WriteLine($"Maximum value initialized to {testArr[0]} at location 0");
            
            //determine max value
            for (int i = 0; i < testArr.Length; i++)
            {
                Console.WriteLine($"Searching index {i}...");
                if (testArr[i] > maxVal)
                {
                    maxVal = testArr[i];
                    Console.WriteLine($"New max of {testArr[i]} at index {i}");
                }
            }

            Console.WriteLine($"Completed Maximum value search...\nOverall Maximum value is {maxVal}\n");

            Console.WriteLine($"Beginning Test for occurrences of Maximum Value of {maxVal}...");
            //determine number of occurrences of max value
            for (int i = 0; i < testArr.Length; i++)
            {
                if (testArr[i] == maxVal)
                {
                    Console.WriteLine($"Instance of Max Value {maxVal} found at index {i}");
                    maxValCount++;
                }
            }

            Console.WriteLine($"Occurrence Count Complete\nFound {maxValCount} total occurrences of Max Value {maxVal}\n");

            //instantiate maxValArr with the correct length it will need
            maxValArr = new int[maxValCount];

            Console.WriteLine("Instantiating Array for indeces of max Value occurrences...\n");

            //declare a variable to keep track of the next empty index of maxValArr
            int nextEmpty = 0;

            //for each maxVal in testArr store its index in maxValArr, and increment the next empty position for maxValArr
            for (int i = 0; i < testArr.Length; i++)
            {
                if (testArr[i] == maxVal)
                {
                    maxValArr[nextEmpty] = i;
                    nextEmpty++;
                }
            }

            Console.WriteLine("Maximum Value Indeces Array Populated, Search complete...\n");
            return maxVal;
        }
    }
}
