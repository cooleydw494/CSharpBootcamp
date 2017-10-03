using System;
using System.IO;

namespace Lab_10A
{
    class Program
    {
        static void Main(string[] args)
        {
            //how to create a file
            //FileStream fs = File.Create(@"F:\C#BootCamp\IO LABS\files\inputFile.txt");

            StreamReader sr = new StreamReader(@"inputFile.txt");

            try
            {
                while (!sr.EndOfStream)
                {
                    Console.Write((char)sr.Read());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Caught - Message: {ex.Message}");
            }
            finally
            {
                sr.Close();
            }
        }
    }
}
