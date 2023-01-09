using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> theColor = new List<string>() { "red", "orange", "yellow" };
            Console.WriteLine("Select a number between 0 and 2.");
            int theIndex = Convert.ToInt32(Console.ReadLine());

            if (theIndex < 0 || theIndex > 2)
            {
                Console.WriteLine("That number is not between O and 2. Pick another number.");
                theIndex = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(theColor[theIndex]);
            Console.ReadLine();
        }
    }
}
