using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            Queue<int> intQueue = new Queue<int>();

            for (int i = 0; i < 10; i++)
            {
                intStack.Push(i);
                intQueue.Enqueue(i);
            }
            foreach (int i in intStack)
            {
                Console.WriteLine($"Stack: {i}");
            }
            foreach (int i in intQueue)
            {
                Console.WriteLine($"Queue: {i}");
            }
        }
    }
}
