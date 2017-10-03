using System;
using System.IO;

namespace Lab10G
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("That's All Folks!");
            }
        }

        static void DoWork()
        {
            File.Create("test2.txt");
			if (File.Exists("test2.txt"))
			{
                File.Delete("test2.txt");
                if (File.Exists("test2.txt"))
                {
                    Console.WriteLine("File not successfully deleted");
                }
                else
                {
                    Console.WriteLine("File successfully deleted");
                }
			}
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }
    }
}