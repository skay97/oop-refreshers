using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlayground
{
    public class User
    {
        // A parameterless constructor is not needed since c# 
        // provides a default constructor when none is provided
        //public User() { }

        public string Name { set; get; }
        public string Occupation {set; get;}

        public override string ToString()
        {
            return $"{Name} is a {Occupation}";
        }
    }
}
