using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_24
{
    class Program
    {
        private static string[] eTypes = { "none", "simple", "index", "nested index" };

        static void Main(string[] args)
        {
            foreach (string eType in eTypes)
            {
                try
                {
                    Console.WriteLine("Main () try block reached");
                    Console.WriteLine($"Throw Exception method for (\"{eType}\") called.");
                    ThrowException(eType);
                    Console.WriteLine("Main () try block continues");
                }
                catch(IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Main () system.IndexOutOfRangeException catch block reached. Message: {ex.Message}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Main () General Catch Block Reached");
                }
                finally
                {
                    Console.WriteLine("Main() finally block reached\n");
                }
            }
        }

        static void ThrowException (string eType)
        {
            Console.WriteLine($"ThrowException(\"{eType}\") reached.");

            switch (eType)
            {
                case "none":
                    Console.WriteLine("Not Throwing an Exception");
                    break;
                case "simple":
                    Console.WriteLine("System.Exception is Being Thrown");
                    throw new Exception();
                case "index":
                    Console.WriteLine("System.IndexOutOfRangeException is Being Thrown");
                    int[] ints = new int[2];
                    ints[5] = 0; //force indexoutofrangeexception
                    break;
                case "nested index":
                    try
                    {
                        Console.WriteLine($"ThrowException(\"{eType}\") try block reached");
                        Console.WriteLine("ThrowException(\"index\") called");
                        ThrowException("index");
                    }
                    catch
                    {
                        Console.WriteLine($"ThrowException(\"{eType}\") catch block reached");
                    }
                    finally
                    {
                        Console.WriteLine($"ThrowException(\"{eType}\") finally block reached");
                    }
                    break;
            }
        }
    }
}