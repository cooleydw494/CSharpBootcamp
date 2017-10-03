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
            Directory.CreateDirectory("testDir");

            if (Directory.Exists("testDir"))
            {
                Console.WriteLine("testDir successfully created");
            }
            else
            {
                Console.WriteLine("testDir not successfully created");
            }

            Console.WriteLine("Please enter a new directory name");
            string newDirName = Console.ReadLine();
            Directory.Move("testDir", newDirName);

            if (Directory.Exists("testDir"))
            {
                Console.WriteLine("testDir still exists / is not renamed");
            }
            else
            {
                Console.WriteLine("testDir is no longer extant");
            }

            if (Directory.Exists(newDirName))
            {
                Console.WriteLine($"testDir successfully renamed as {newDirName}");
            }
        }
    }
}