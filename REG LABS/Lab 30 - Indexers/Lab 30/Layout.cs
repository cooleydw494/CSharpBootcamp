using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_30
{
    class Layout
    {
        private string[] stringArray = new string[100];

        public string this[int number]
        {
            get
            {
                if (number >= 0 && number < stringArray.Length)
                {
                    return stringArray[number];
                }
                else
                {
                    return "Error";
                }
            }
            set
            {
                if (number >= 0 && number < stringArray.Length)
                {
                    stringArray[number] = value;
                }
            }
        }
    }
}
