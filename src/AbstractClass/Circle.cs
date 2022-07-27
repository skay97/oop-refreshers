using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Circle : Drawing
    {
        private int r;

        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public override double Area()
        {
            return r * r * Math.PI;
        }

        public override string ToString()
        {
            return string.Format("Circle info: x: {0}, y: {1}, radius: {2}", x, y, r);
        }
    }
}
