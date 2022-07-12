using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlayground
{
    internal class Circle
    {
        private int radius;

        public Circle(int radius)
        {
            Console.WriteLine($"Circle, r={radius} is created");
        }

        /// <summary>
        /// Constructor chaning: this empty contrcutor calls another constructor that
        /// only takes an int and executes that constructor with the value of 1
        /// </summary>
        public Circle() : this(1) { }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
