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
            p1.Name = "Salman";

            var p2 = new Person();
            p2.Name = "Eman";

            Console.WriteLine($"this is p1.Name: {p1.Name}");
            Console.WriteLine($"this is p2.Name: {p2.Name}");
        }
    }
}
