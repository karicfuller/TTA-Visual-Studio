using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiate object
            List<Employee> employees = new List<Employee>() //creating list named employees
            {
                new Employee (){ FirstName = "Joe", Id = 12, LastName = "Smith"},
                new Employee (){ FirstName = "Mary", Id = 34, LastName = "Jane"},
                new Employee (){ FirstName = "Joe", Id = 7, LastName = "Bob"},
                new Employee (){ FirstName = "Sam", Id = 8, LastName = "Jones"},
                new Employee (){ FirstName = "Jerry", Id = 5, LastName = "Martin"},
                new Employee (){ FirstName = "Kari", Id = 4, LastName = "Fuller"},
                new Employee (){ FirstName = "Oscar", Id = 3, LastName = "Prado"},
                new Employee (){ FirstName = "Matt", Id = 7, LastName = "Aman"},
                new Employee (){ FirstName = "Cheryl", Id = 2, LastName = "Hoy"},
                new Employee (){ FirstName = "Dan", Id = 9, LastName = "Hoy"}
            };

            List<Employee> emptyList = new List<Employee>(); //create empty list
            foreach (Employee listNames in employees) //iterate through list
            {
                if (listNames.FirstName == "Joe")  //if first name is Joe
                {
                    emptyList.Add(listNames); //add to empty list
                }
            }
            List<Employee> theList = employees.Where(x => x.FirstName == "Joe").ToList(); //pulling first names = Joe
            List<Employee> theId = employees.Where(x => x.Id > 5).ToList(); //pulling ids > 5
            Console.ReadLine();
            
        }
    }
}
