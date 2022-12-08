using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public abstract class Person
    {
        public string firstName { get; set; } //first property
        public string lastName { get; set; } //second property

        public abstract void SayName(); //method
    }
}
