using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_54
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> books = new SortedList<string, string>()
            {
                ["Curly's Lament"] = "978-0-470-38461-9",
                ["Nightmare at Fenway"] = "978-0-470-19135-4",
                ["Remembrance of Things Past"] = "978-0-470-19137-6",
                ["The Stooge Mystique"] = "978-0-470-047205-7"
            };

            foreach (KeyValuePair<string, string> book in books)
            {
                Console.WriteLine(book.Key);
            }
            Console.WriteLine();

            foreach (KeyValuePair<string, string> book in books)
            {
                Console.WriteLine(book.Value);
            }
            Console.WriteLine();

            foreach (KeyValuePair<string, string> book in books)
            {
                Console.WriteLine($"Title: {book.Key}, ISBN: {book.Value}");
            }
        }
    }
}
