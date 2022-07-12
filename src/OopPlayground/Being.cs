using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlayground
{
    public class Being
    {
        public Being()
        {
            Console.WriteLine("Being is created");
        }

        public Being(string being)
        {
            Console.WriteLine($"Being {being} is created");
        }
    }
}
