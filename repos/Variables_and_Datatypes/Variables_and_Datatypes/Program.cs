using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_and_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine(); //keeps window open

            // cast string to int

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNumber = Convert.ToInt32(favoriteNumber);
            //int total = favNumber + 5;
            //Console.WriteLine("Your favorite number is: " + total);
            //Console.ReadLine();

            // cast int to string

            int currentAge = 30;
            string yearOld = currentAge.ToString();

            // boolean to string

            bool isRainging = true;
            string rainingStatus = Convert.ToString(isRainging);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();


        }
    }
}
