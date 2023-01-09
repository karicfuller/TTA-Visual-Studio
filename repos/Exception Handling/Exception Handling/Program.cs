using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex) //ex = variable
            {
                Console.WriteLine("Please pick a whole number."); //(ex.Message) will display format error message
                return; //will take you to another page
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by 0.");
            }
            catch (Exception ex) //general exception
            {
                Console.WriteLine(ex.Message);
            }
            finally //both answers are correct
            {
                Console.ReadLine();
            }

            
        }
    }
}
