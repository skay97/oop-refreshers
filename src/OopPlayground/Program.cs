using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new Being();
            Console.WriteLine($"this is b: {b}");

            var p1 = new Person();
            // Person.Name is a public property with public setters, therefore we
            // can explictly update the value outside of its class.
            p1.Name = "Salman";

            var p2 = new Person();
            p2.Name = "Eman";

            Console.WriteLine($"this is p1.Name: {p1.Name}");
            Console.WriteLine($"this is p2.Name: {p2.Name}");

            Circle circle = new Circle();
            // Circle.Radius is a private field which does not allow its value to be EXPLICITLY updated
            // outside of the Circle class. Updating its value requires us to use the following public method 
            circle.SetRadius(5);

            Console.WriteLine($"this is the circle's area: {circle.Area()}");
        }
    }
}
