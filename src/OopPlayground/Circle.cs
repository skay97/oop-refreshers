using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlayground
{
    internal class Circle : Shape
    {
        //private int radius;
        private int r;

        public Circle(int radius)
        {
            Console.WriteLine($"Circle, r={radius} is created");
        }


        /// <summary>
        /// Constructor chaining: this empty constructor calls another constructor that
        /// only takes an int and executes that constructor with the value of 1
        /// </summary>
        public Circle() : this(1) { }

        public Circle(int radius, int x, int y) : base(x, y)
        {
            r = radius;
        }

        public override string ToString()
        {
            return string.Format("Circle, r:{0}, x:{1}, y:{2}", r, x, y);
        }

        public void SetRadius(int radius)
        {
            r = radius;
        }

        public double Area()
        {
            return Math.PI * r * r;
        }
    }
}
