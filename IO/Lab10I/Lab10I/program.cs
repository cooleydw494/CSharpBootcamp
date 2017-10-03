using System;
using System.IO;

namespace Lab10I
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
            Directory.CreateDirectory("testDir");
            Directory.CreateDirectory("testDir/test");
			if (Directory.Exists("testDir"))
			{
                Directory.Delete("testDir", true);
                if (File.Exists("testDir"))
                {
                    Console.WriteLine("Directory not successfully deleted");
                }
                else
                {
                    Console.WriteLine("Directory successfully deleted");
                }
			}
            else
            {
                Console.WriteLine("Directory Does Not Exist");
            }
        }
    }
}