using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlayground
{
    public class Shape
    {
        protected int x;
        protected int y;

        public Shape()
        {
            Console.WriteLine("Shape is created");
        }

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
