using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); //title

            Console.WriteLine("What is the weight of the package?");
            int packWeight = Convert.ToInt32(Console.ReadLine());  //convert user input to int

            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); //end of program
            }
            else
            {
                Console.WriteLine("What is the width of the package?");
                int packWidth = Convert.ToInt32(Console.ReadLine()); //convert user input to int

                Console.WriteLine("What is the package height?");
                int packHeight = Convert.ToInt32(Console.ReadLine()); //convert user input to int

                Console.WriteLine("What is the package length?");
                int packLength = Convert.ToInt32(Console.ReadLine()); //convert user input to int

                if (packWidth + packHeight + packLength > 50)  //total of width+height+length is more than 50
                {
                    Console.WriteLine("Package too big to be shipped via Package Express."); //end of program
                }
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is:");
                    int result = packHeight * packWidth * packLength; //multiply height*width*length
                    int multWeight = result * packWeight;  //multiply by weight
                    int divResult = multWeight / 100; //divide by 100 for total cost

                    Console.WriteLine("$" + divResult); //total cost
                }
            }
            Console.ReadLine();
        }
    }
}
