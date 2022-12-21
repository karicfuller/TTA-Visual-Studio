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
            Console.WriteLine("Enter your age.");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ZeroException();
                }

                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;
                Console.WriteLine("You were born in the year " + birthYear);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please use a whole nummber.");
            }
            catch (ZeroException)
            {
            }
            Console.ReadLine();
        }
    }
}
