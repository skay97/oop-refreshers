using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Drawing
    {
        protected int x = 0;
        protected int y = 0;

        public abstract double Area();

        public string GetCoordinates()
        {
            return string.Format("x: {0}, y: {1}", x, y);
        }
    }
}
