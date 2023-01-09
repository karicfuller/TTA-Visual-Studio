using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int age = Convert.ToInt32(yourAge); //convert string to int

            Console.WriteLine("You have a DUI? True or False?");
            string haveDUI = Console.ReadLine();
            bool dui = Convert.ToBoolean(haveDUI);  //convert string to bool

            Console.WriteLine("How many speeding tickets do you have?");
            string speedTickets = Console.ReadLine();
            int haveTickets = Convert.ToInt32(speedTickets);  //conver string to int

            bool finding = age > 15 && dui == false && haveTickets < 3; //equation to find yes or no
            Console.WriteLine("Are you qualified? " + finding);
            Console.ReadLine();
        }
    }
}
