using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiate object
            employee.firstName = "Sample"; //property
            employee.lastName = "Student"; //property
            employee.SayName(); //calling SayName
            Console.ReadLine();
        }
    }
}
