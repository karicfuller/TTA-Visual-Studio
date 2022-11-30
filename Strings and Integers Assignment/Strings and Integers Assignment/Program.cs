using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> aNumber = new List<int>() { 2, 4, 6, 8 }; //list of integers to be divided by user's number
                Console.WriteLine("Pick a whole number."); //request user select a number
                int pickedNumber = Convert.ToInt32(Console.ReadLine()); //convert user's number to string

                for (int i = 0; i < 4; i++) //iterate through list of integers
                {
                    Console.WriteLine(aNumber[i] / pickedNumber); //number from list divided by user's number
                }
            }
            catch (FormatException ex) //issue with format
            {
                Console.WriteLine("That's not a whole number."); //error message
            }
            catch (DivideByZeroException ex) //if zero is entered
            {
                Console.WriteLine("You can't divide by zero."); //error message
            }
            catch (Exception ex) //general exception
            {
                Console.WriteLine(ex.Message); //error message
            }
            finally //guarantees following line of code will be called
            {
                Console.ReadLine();
            }
            
        }
    }
}
