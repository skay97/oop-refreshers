using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlayground
{
    internal class Derived : Base
    {
        /// <summary>
        /// Write basic info pertaining to Derived to the console
        /// </summary>
        public void Info()
        {
            Console.WriteLine("Here is what we inherited from the base class:");
            Console.WriteLine($"this.name: {this.name}");
            Console.WriteLine($"this.id: {this.id}");
            // Since isDefined is a private field within the base class it is not inherited
            //Console.WriteLine($"this.isDefined: {this.isDefined}");
        }
    }
}
