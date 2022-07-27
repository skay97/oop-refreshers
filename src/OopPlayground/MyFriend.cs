using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlayground
{
    internal class MyFriend
    {
        private DateTime born;
        private string name;

        public MyFriend(string name, DateTime born)
        {
            // We use the "this" keyword prior to setting the value for the following fields
            // because our params have the same name as the field. Thus, this.name eliminates ambiguity
            // and lets us know that we're referencing the field rather than the param.
            this.name = name; // instantiates field to value received from newing up the MyFriend class
            this.born = born;
        }

        public void Info()
        {
            // We do not have to use the this prefix prior to referencing the following fields
            // because they do not conflict with similar name params/vars
            Console.WriteLine("{0} was born on {1}", name, born.ToShortDateString());
        }
    }
}
