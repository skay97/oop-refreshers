using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

            Console.WriteLine(worker.DoWork());
            Console.WriteLine(worker.DoWork());
            Console.WriteLine(worker.DoPause());
        }
    }
}
