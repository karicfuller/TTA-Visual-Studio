using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Date_Time_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            Console.WriteLine("Pick a number");
            int inputTime = Convert.ToInt32(Console.ReadLine());
            DateTime dateTime = currentTime.AddHours(inputTime);
            Console.WriteLine(dateTime);

            Console.ReadLine();
        }
    }
}