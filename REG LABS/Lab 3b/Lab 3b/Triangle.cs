using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3b
{
    class Triangle
    {
        private int side1;
        private int side2;
        private int side3;

        //default constructor
        public Triangle()
        {
            this.side1 = this.side2 = this.side3 = 1;
            Console.WriteLine("Triangle with {0} default sides created", 3);
        }
        //one arg constructor
        public Triangle(int side1)
        {
            this.side1 = side1;
            this.side2 = this.side3 = 1;
            Console.WriteLine("Triangle with {0} default sides created", 2);
        }
        //two arg constructor
        public Triangle(int side1, int side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = 1;
            Console.WriteLine("Triangle with {0} default sides created", 1);
        }
        //three arg constructor
        public Triangle(int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            Console.WriteLine("Triangle with {0} default sides created", 0);
        }
        
        //get methods
        public int getSideOne()
        {
            return side1;
        }
        public int getSideTwo()
        {
            return side2;
        }
        public int getSideThree()
        {
            return side3;
        }

        //set methods
        public void setSideOne (int side1)
        {
            this.side1 = side1;
        }
        public void setSideTwo (int side2)
        {
            this.side2 = side2;
        }
        public void setSideThree (int side3)
        {
            this.side3 = side3;
        }
    }
}
