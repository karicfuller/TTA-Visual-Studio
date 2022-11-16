using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Operator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comaparison Program");  //title

            //Person 1 info
            Console.WriteLine("Person 1");

            Console.WriteLine("What is your hourly rate?");
            string hourlyRate = Console.ReadLine();
            double rateHourly = Convert.ToDouble(hourlyRate);

            Console.WriteLine("How many hours do you work a week?");
            string numOfHours = Console.ReadLine();
            double hoursPerWeek = Convert.ToDouble(numOfHours);

            Console.WriteLine("Annual Salary of Person 1");
            Console.WriteLine(rateHourly * hoursPerWeek * 52); //hourly pay*hours worked a week*52

            //Person 2 info
            Console.WriteLine("Person 2");

            Console.WriteLine("What is your hourly rate?");
            string ratePerHour = Console.ReadLine();
            double hourlyAmount = Convert.ToDouble(ratePerHour);

            Console.WriteLine("How many hours do you work a week?");
            string amountOfHours = Console.ReadLine();
            double hoursOfWork = Convert.ToDouble(amountOfHours);

            Console.WriteLine("Annual Salary of Person 2");
            Console.WriteLine(hourlyAmount * hoursOfWork * 52); //hourly pay*hours worked a week*52

            Console.ReadLine();  //keep open

            




        }
    }
}
