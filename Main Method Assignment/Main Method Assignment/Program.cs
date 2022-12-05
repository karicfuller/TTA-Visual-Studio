using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods method = new Methods(); //incorporating classes

            int aNumber = method.Addition(5); //taking in the number 5 for the addition
            Console.WriteLine(aNumber); //answer to 5 + 1
            Console.WriteLine(method.Addition(5m)); //decimal -> int
            Console.WriteLine(method.Addition("3")); //string -> int
            Console.ReadLine();
        }
            
        
    }
}
