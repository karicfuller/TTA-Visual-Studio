using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person() : this("Bob") //object setting Bob as default name
        {

        }
        public Person(string name) : this(name, 20) //setting 20 as default age
        {

        }
        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
    }
}
