using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //object
            Employee employee2 = new Employee();//object
            employee.Id = 2; //employee Id
            employee2.Id = 3; //employee Id
            Console.WriteLine(employee == employee2); //output will be comparison to see if they are the same(true) or not(false)
            Console.ReadLine();
        }
    }
}
