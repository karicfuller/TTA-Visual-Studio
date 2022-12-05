using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a number.");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Operators aClass = new Operators(); //Operators is name of class

            int theNumber = aClass.Addition(inputNumber);
            int nextNumber = aClass.Subtract(inputNumber);
            int finalNumber = aClass.Mulitply(inputNumber);
            Console.WriteLine(theNumber);
            Console.WriteLine(nextNumber);
            Console.WriteLine(finalNumber);

            Console.ReadLine();
        }

    }
}
