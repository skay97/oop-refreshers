using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Circle(12, 45, 22);

            Console.WriteLine(c);
            Console.WriteLine("Area of the circle is {0}", c.Area());
            Console.WriteLine(c.GetCoordinates());
        }
    }
}
