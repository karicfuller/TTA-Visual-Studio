using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Employee : Person, IQuittable //Employee class inherits from the Person class
    {
        public override void SayName() //implementing from Person class
        {
            Console.WriteLine("This is implementing the SayName from Person class");
        }
        public void Quit() //calling/inheriting method
        {
            Console.WriteLine("Implementation");
        }
    }
}
