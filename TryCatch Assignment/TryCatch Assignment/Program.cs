using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age."); //requesting age of user
            try
            {
                int age = Convert.ToInt32(Console.ReadLine()); //converting 
                if (age <= 0) 
                {
                    throw new ZeroException(); //use message from ZeroException class
                }

                int currentYear = DateTime.Now.Year; //current year
                int birthYear = currentYear - age;  //current year minus age
                Console.WriteLine("You were born in the year " + birthYear);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please use a whole nummber."); //if input is not a number
            }
            catch (ZeroException) 
            {
            }
            Console.ReadLine();
        }
    }
}
