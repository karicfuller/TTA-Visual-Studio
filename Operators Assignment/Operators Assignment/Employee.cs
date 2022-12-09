using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Employee
    {
        public int Id { get; set; } //property 
        public string FirstName { get; set; } //property
        public string LastName { get; set; } //property

        public static bool operator ==(Employee employee, Employee employee2)
        {
            return employee.Id == employee2.Id;
        }
        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.Id != employee2.Id;
        }
    }
}

