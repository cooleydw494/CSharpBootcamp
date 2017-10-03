using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_30A
{
    class Program
    {
        static void Main(string[] args)
        {
            IntIndexer indexer = new IntIndexer(10);

            indexer[3] = "Any Value";
            indexer[5] = "Some Value";
            indexer[7] = "Another Value";

            for (int i = 0; i < indexer.Size; i++)
            {
                Console.WriteLine(indexer[i]);
            }
        }
    }
}
