using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> alphabet = new Stack<char>();
            Queue<char> alphabetQ = new Queue<char>();

            alphabet.Push('A');
            alphabet.Push('B');
            alphabet.Push('C');

            alphabetQ.Enqueue('A');
            alphabetQ.Enqueue('B');
            alphabetQ.Enqueue('C');

            Console.WriteLine("STACK...");
            Console.WriteLine("First Iteration");
            foreach(char letter in alphabet)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine("Second Iteration");
            while (alphabet.Count > 0)
            {
                Console.WriteLine(alphabet.Pop());
            }

            Console.WriteLine("\nQUEUE...");
            Console.WriteLine("First Iteration");
            foreach(char letter in alphabetQ)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine("Second Iteration");
            while (alphabetQ.Count > 0)
            {
                Console.WriteLine(alphabetQ.Dequeue());
            }

        }
    }
}
