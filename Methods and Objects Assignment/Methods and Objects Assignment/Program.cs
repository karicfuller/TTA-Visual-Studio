using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiating Employee object
            employee.FirstName = ("Sample"); //Person property #1
            employee.LastName = ("Student"); //Person property #2
            employee.SayName(); //calling superclass
            Console.ReadLine();
        }
    }
}
