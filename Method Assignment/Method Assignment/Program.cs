using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter one or two numbers, one at a time.");
            int inputNums = Convert.ToInt32(Console.ReadLine());
            
            Methods method = new Methods();

            try
            {
                int anotherNum = Convert.ToInt32(Console.ReadLine());
                int number1 = method.twoInt(inputNums, anotherNum);
                Console.WriteLine(number1);
            }
            catch
            {
                int number2 = method.twoInt(inputNums);
                Console.WriteLine(number2);
            }

            Console.ReadLine();
            
        }
    }
}
