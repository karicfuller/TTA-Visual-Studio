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
            int year = Convert.ToInt32(Console.ReadLine());  //conver string to int
            bool theYear = year == 2022; //correct answer

            while (year < 1950)  //while loop if year is before 1950
            {
                Console.WriteLine("Wow, that was a long time ago. Wrong! Try again.");
                Console.WriteLine("Guess a year!");
                Console.ReadLine();
                break;
            }

            do
            {
                switch (year)
                {
                    case 1976:  //if year 1976 is selected
                        Console.WriteLine("You guessed the year 1976. Wrong! Try again.");
                        Console.WriteLine("Guess a year!");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2000: //if year 2000 is selected
                        Console.WriteLine("You guessed the year 2000. Wrong! Try again.");
                        Console.WriteLine("Guess a year!");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1984: //if year 1984 is selected
                        Console.WriteLine("You guessed the year 1984. Wrong! Try again.");
                        Console.WriteLine("Guess a year!");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2022: //correct year
                        Console.WriteLine("You guessed the year 2022. Yes! That is it!");
                        theYear = true;
                        break;
                    default: //any other number
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