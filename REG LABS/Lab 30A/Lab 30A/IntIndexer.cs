using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_30A
{
    class IntIndexer
    {
        private string[] stringArray;

        public int Size { get; set; }
        
        public IntIndexer()
        {

        }

        public IntIndexer(int size)
        {
            Size = size;
            stringArray = new string[size];
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = "EMPTY";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < stringArray.Length)
                {
                    return stringArray[index];
                }
                else
                {
                    return "Error";
                }
            }
            set
            {
                if (index >= 0 && index < stringArray.Length)
                {
                    stringArray[index] = value;
                }
            }
        }
    }
}
