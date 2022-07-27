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

        // Example of an expression-bodied constructor:
        public User(string name, string occupation) =>
            (Name, Occupation) = (name, occupation);

        private string Name { set; get; }
        private string Occupation {set; get;}

        //public override string ToString()
        //{
        //    return $"{Name} is a {Occupation}";
        //}

        // Updates override logic to use an expression instead of braces
        public override string ToString() =>
            $"User {Name} is a {Occupation}";
    }
}
