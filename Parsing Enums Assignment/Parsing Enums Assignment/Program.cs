using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day of the week is it?");
                string value = Console.ReadLine();
                DayOfWeek dayweek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), value);
                Console.WriteLine("That's correct, today is " + dayweek);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
            public enum DayOfWeek
                {
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday,
                Sunday
                }
            
        }
        
    }

