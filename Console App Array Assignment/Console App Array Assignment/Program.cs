using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] anArray = { "Kari", "Oscar", "Matt" };  //0=Kari, 1=Oscar, 2=Matt
            Console.WriteLine("Pick a number between 0 and 2");  //asking for an index
            int theIndex = Convert.ToInt32(Console.ReadLine());  //converts string to int

            if (theIndex > 2)  //if user picks number greater than 2
            {
                Console.WriteLine("That number is greater than a number betweem 0 and 2. Pick another number.");
                theIndex = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(anArray[theIndex]); //selects the name in chosen index



            int[] anInt = { 2, 4, 6, 8 };   // 0=2, 1=4 2=6, 3=8
            Console.WriteLine("Pick a number between 0 and 3");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            if (intIndex > 3)  //if user selects number greater than 3
            {
                Console.WriteLine("That number is greater than a number betweem 0 and 3. Pick another number.");
                intIndex = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(anInt[intIndex]);
          

            Console.ReadLine();
  
        }
    }
}
