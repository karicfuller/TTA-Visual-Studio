using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method(); //instatiating object naming it method

            Console.WriteLine("Enter a number"); //requesting number from user
            int inputNum = Convert.ToInt32(Console.ReadLine()); //converting string to integer

            method.twoInts(inputNum); //calling method

            int i = 0;
            int j = 0;

            method.outParameter(out i, out j); //object.method
            Console.WriteLine(i + " " + j);

            StaticClass.VoidMethod(); //static class doesn't need object - class.method

            Console.ReadLine();

            
        }
            
        

    }
}
