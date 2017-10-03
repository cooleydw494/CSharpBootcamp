using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_101
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Hey");
            list.Add("Howdy");
            list.Add("whats up");
            list.Add("sup");
            list.Add("hows it going?");
            list.Add("Good morning");

            list.Sort();

            list.GetEnumerator();
        }
    }
}
