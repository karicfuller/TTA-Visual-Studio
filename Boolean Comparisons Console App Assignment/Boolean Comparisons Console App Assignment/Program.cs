using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Comparisons_Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a year!");
            int year = Convert.ToInt32(Console.ReadLine());
            bool theYear = year == 2022;

            do
            {
                switch (year)
                {
                    case 1976:
                        Console.WriteLine("You guessed the year 1976. Wrong! Try again.");
                        Console.WriteLine("Guess a year!");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2000:
                        Console.WriteLine("You guessed the year 2000. Wrong! Try again.");
                        Console.WriteLine("Guess a year!");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1984:
                        Console.WriteLine("You guessed the year 1984. Wrong! Try again.");
                        Console.WriteLine("Guess a year!");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2022:
                        Console.WriteLine("You guessed the year 2022. Yes! That is it!");
                        theYear = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong!");
                        Console.WriteLine("Guess a year!");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!theYear);
            
            Console.ReadLine();

        }
    }
}
