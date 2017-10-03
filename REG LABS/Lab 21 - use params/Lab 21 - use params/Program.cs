using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_21___use_params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Summed Values = {sumVals(5, 9, 3, 5, 6)}");
            Console.WriteLine($"Summed Values = {sumVals(5, 9, 3, 5, 6, 7, 8, 9, 20)}");
            Console.WriteLine($"Summed Values = {sumVals(129, 345, 2000)}");
            Console.WriteLine($"Summed Values = {sumVals(6, 6, 9, 9, 3, 4)}");
        }

        public static int sumVals (params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
    }
}