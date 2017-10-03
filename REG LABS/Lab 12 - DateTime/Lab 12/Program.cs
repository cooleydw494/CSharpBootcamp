using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myBirthday = new DateTime(1992, 03, 18);
            Console.WriteLine("My birthday is {0:MM/dd/yyyy}", myBirthday);
            Console.WriteLine("Today's date is {0:MM/dd/yyyy}", DateTime.Today);
            Console.WriteLine("Yesterday's date was {0:MM/dd/yyyy}", GetYesterday());
            Console.WriteLine("One Year Ago the date was {0:MM/dd/yyyy}", GetYearAgo());
            Console.WriteLine("The current date and time is {0:MM/dd/yyyy} and it is {0:h:m tt}", DateTime.Now);
            Console.WriteLine("A much more specific (and military) current time is {0:dddd, MMMM dd, yyyy gg HH:mm:ss tt}", DateTime.Now);
        }

        public static DateTime GetYesterday()
        {
            DateTime today = DateTime.Today;
            return today.AddDays(-1);
        }
        public static DateTime GetYearAgo()
        {
            DateTime today = DateTime.Today;
            return today.AddYears(-1);
        }
    }
}