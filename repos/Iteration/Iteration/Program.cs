using System;   //need
using System.Collections.Generic;   //need
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)  //need string[] args
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //1st condition-starting value, 2nd condition-how long do for loop(less than length), 3rd condition-what to do after for loop runs (adds 1 to i)
            //for (int i = 0; i < testScores.Length; i++) //"i" can be any letter and usually = 0
            //{
            //    if (testScores[i]> 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //String Array
            //string[] names = { "Kari", "Oscar", "Matt", "Sean" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    //if (names[j] == "Kari")
            //    //{
            //        Console.WriteLine(names[j]); //shortcut to list all names

            //    //}
            //}
            //Console.ReadLine();


            //Iteration of Lists

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores) //"score" is a variable name(can be named anything)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //}
            //Console.ReadLine();

            //List strings (Lists names are usually plural

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names) //string name is "names" (plural)
            //{
            //    Console.WriteLine(name); //easy way to write out all names in array
            //}
            //Console.ReadLine();


            //Add item of list to another list if it meets certain condition

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>(); //creates blank list

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
