using System;
using System.IO;

namespace Lab10J
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Thrown Type: {ex.GetType().Name}");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("That's All Folks!");
            }
        }

        static void DoWork()
        {
            File.Create("test.txt");

            if (File.Exists("test.txt"))
            {
                Console.WriteLine("test.txt successfully created");
            }
            else
            {
                Console.WriteLine("test.txt not successfully created");
            }

            Console.WriteLine("Please enter a new file name");
            string newFileName = Console.ReadLine();
            File.Move("test.txt", newFileName);

            if (File.Exists("test.txt"))
            {
                Console.WriteLine("test.txt still exists / is not renamed");
            }
            else
            {
                Console.WriteLine("test.txt is no longer extant");
            }

            if (File.Exists(newFileName))
            {
                Console.WriteLine($"test.txt successfully renamed as {newFileName}");
            }
        }
    }
}