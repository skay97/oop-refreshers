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
            Console.WriteLine($"this is b - called without string param: {b}");

            var b2 = new Being("Human");

            var p1 = new Person();
            // Person.Name is a public property with public setters, therefore we
            // can explictly update the value outside of its class.
            p1.Name = "Salman";

            // Person also has an age field which is private. If a member field is private,
            // the only way to modify it is via methods. If we want to EXPLICITLY modify an attribute
            // OUTSIDE of the class, the method must be declared public.
            p1.SetAge(25);

            var p2 = new Person();
            p2.Name = "Eman";

            Console.WriteLine($"this is p1.Name: {p1.Name} and they are {p1.GetAge()} {(p1.GetAge() > 1 ?  "years" : "year")} old");
            Console.WriteLine($"this is p2.Name: {p2.Name}");

            new Circle(5);
            Circle circle = new Circle();
            // Circle.Radius is a private field which does not allow its value to be EXPLICITLY modified
            // outside of the Circle class. Modifying its value requires us to use the following public method 
            circle.SetRadius(5);

            Console.WriteLine($"this is the circle's area: {circle.Area()}");

            // Illustrate inheritance concept
            var d = new Derived();
            d.Info();

            // Instantiating the following instructs the constructor to set the values 
            // for MyFriend.name and MyFriend.Born to the parameters MyFriend has been given
            var friend = new MyFriend("Rooshna", new DateTime(1997, 1, 10));
            friend.Info();

            // We are using object initializers below to set values to accessible properties.
            // This allows us to set values for a property/field without having to invoke a consturctor.
            // The parenthesis after the user is not required since user does not have a constructor whule ammount 
            // with required values.
            var u = new User() { Name = "Salman Karim", Occupation = "SWE" };
            Console.WriteLine("THIS IS u: " + u);
        }
    }
}
