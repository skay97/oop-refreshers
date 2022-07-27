using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlayground
{
    public class Being
    {
        static int count = 0;
        public Being()
        {
            count++;
            Console.WriteLine("Being is created");
        }

        public void GetCount()
        {
            Console.WriteLine("There are {0} Beings", count);
        }

        public Being(string being)
        {
            // Anytime this constructor is called, the following statement in executed
            Console.WriteLine($"Being {being} is created");
        }
    }
}
