using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Person
    {
        public string FirstName { get; set; } //first property
        public string LastName { get; set; } //second property

        public void SayName() //superclass
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
