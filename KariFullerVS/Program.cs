using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Student_Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); 
            Console.WriteLine("TTA Student Daily Report");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string whatPageNum = Console.ReadLine();
            int pageNum = Convert.ToInt32(whatPageNum); //converts string to int

            Console.WriteLine("Do you need help with anything? Please answer True of False?");
            string needHelp = Console.ReadLine();
            bool help = Convert.ToBoolean(needHelp); //converts string to boolean

            Console.WriteLine("Were there any positive experiences you'd like to provide? Please give specifics.");
            string posExperience = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int hoursOfStudy = Convert.ToInt32(studyHours); //converts string to int

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine(); //keeps window open
        }
    }
}
