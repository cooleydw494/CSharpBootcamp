using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20___Arrays_4
{
    class Program
    {
        private static int[] ints = { 4, 6, 23, 90, 34, 16, 12, 40, 29, 0 };

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"The maximum value in my array is { MaxValue(ints)}");

                //THROW AN ERROR ON PURPOSE
                int n1 = 9;
                int n2 = 0;
                int n3 = n1 / n2;
            }

            catch (Exception ex)
            {
                Console.WriteLine($"You messed something up,\nThe compiler says {ex.Message}");
            }
        }

        static int MaxValue(int[] intArr)
        {
            int maxValue = 0;
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine($"Value of element at position {i} = {intArr[i]}");
                if (intArr[i] > maxValue)
                {
                    maxValue = intArr[i];
                }
            }
            return maxValue;
        }
    }
}
