using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1 ASSIGNMENT

            //an array of 4 months for the user to choose from
            //string[] anArray = { "January", "February", "March", "April" }; 
            //Console.WriteLine("What are one of the first four months of the year?"); //asking userr to select month
            //string theMonth = Console.ReadLine();

            //for (int i = 0; i < anArray.Length; i++)  //loop through the array
            //{
            //    anArray[i] = anArray[i] + theMonth; //adds month to array
            //}
            //foreach (string theArray in anArray)
            //{
            //    Console.WriteLine("You selected " + theArray);
            //}
            //Console.ReadLine();


            ////PART 2 ASSIGNMENT

            //while (true) //create infinite loop
            //{
            //    Console.WriteLine("This is an infinite loop!"); //will print continuously
            //    break; //break will cause the infinite loop to end
            //}
            //Console.ReadLine();


            ////PART 3 ASSIGNMENT

            int[] theInt = { 5, 7, 9, 10, 15, 20 }; //array to iterate through

            for (int i = 0; i < theInt.Length; i++) //iterating through array
            {
                if (theInt[i] < 10) //if number in array is less than 10
                {
                    Console.WriteLine("The nummber " + theInt[i] + " is less than 10."); //console will read the sentence
                }
                if (theInt[i] <= 10) //if number in array is less or equal to 10
                {
                    Console.WriteLine("The number " + theInt[i] + " is less than or equal to 10."); //console will read sentence
                }
            }
            for (theInt[i] <= 10)
            {
                Console.WriteLine("The number " + theInt[i] + " is less than or equal to 10."); //console will read sentence
            }

            Console.ReadLine();

            //PART 4 ASSIGNMENT

            //List<string> theColor = new List<string>() { "red", "orange", "yellow"}; //list of strings
            //Console.WriteLine("Select red, orange, or yellow."); //prompts user to select color
            //string pickedColor = Console.ReadLine(); //user input

            //for (int i = 0; i < 3; i++) //iterates through the list
            //{
            //    if (theColor[i] == pickedColor) //index of the selected color
            //    {
            //        Console.WriteLine(i); //index
            //        break; //stops loop
            //    }
            //}
            //if (!theColor.Contains(pickedColor)) //if the color selected by user isn't one of the options
            //{
            //    Console.WriteLine("Match not found."); //error message
            //}
            //Console.ReadLine();


            //PART 5 ASSIGNMENT

            //List<string> theNames = new List<string>() { "Kari", "Oscar", "Matt", "Kari" }; //list of names
            //Console.WriteLine("Select one of the names: Kari, Oscar, or Matt."); //ask user to select name from list
            //string selectedName = Console.ReadLine(); //user input

            //for (int i = 0; i < 4; i++) //iterate through list
            //{
            //    if (theNames[i] == selectedName) //assign index
            //    {
            //        Console.WriteLine(i); //index
            //    }
            //}
            //if (!theNames.Contains(selectedName)) //if user inputs name not from list
            //{
            //    Console.WriteLine("No match found"); //error message
            //}
            //Console.ReadLine();


            //PART 6 ASSIGNMENT

            List<string> aFruit = new List<string>() { "apple", "orange", "grape", "apple" }; //list of strings
            List<string> aFruitBackUp = new List<string>(); //create backup list that will store strings as iterated

            foreach(string item in aFruit) //for each string in the list
            {
                if (aFruitBackUp.Contains(item)) //if the backup list already contains the item
                {
                    Console.WriteLine(item + " has appeared before."); //console will say it has appeared before
                }
                else //otherwise
                {
                    Console.WriteLine(item + " has not appeared before."); //console will say it has not appeared before
                }
                aFruitBackUp.Add(item);

            }
            Console.ReadLine();
        }
    }
}


