using System;
using System.IO;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream outStream = null;
            FileStream inStream = null;
            try
            {
                outStream = File.OpenWrite(@"F:\C#BootCamp\IO LABS\files\DestinationFile.txt");
                inStream = File.OpenRead(@"F:\C#BootCamp\IO LABS\files\inputFile.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Thrown - Message: {ex.Message}");
            }
            finally
            {
                    outStream.Close();
                    inStream.Close();
            }
        }
    }
}
