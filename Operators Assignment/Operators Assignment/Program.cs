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
            Employee employee = new Employee();
            Employee employee2 = new Employee();
            employee.Id = 2;
            employee2.Id = 3;
            Console.WriteLine(employee == employee2);
            Console.ReadLine();
        }
    }
}
