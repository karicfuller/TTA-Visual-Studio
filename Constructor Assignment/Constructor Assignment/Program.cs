using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const string name = "Tom"; 
            var age = 30; 
            Person p1 = new Person(); // will pull default from constructor on Person.cs
            Person p2 = new Person(name); //name = Tom
            Person p3 = new Person(name, age); //name = Tom, age = 30
            Console.ReadLine();
        }

    }
}
