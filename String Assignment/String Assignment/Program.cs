using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string mom = "Cheryl";
            string dad = "Dan";
            string dog = "Trigger";
            string family = "My mom's name is " + mom + ", my dad's name is " + dad + ", and I have a dog named " + dog + "!";

            Console.WriteLine(family);

            string friend = "oscar";
            friend = friend.ToUpper();
            string bestFriend = "My best friend's name is " + friend + "!";
            
            Console.WriteLine(bestFriend);
            
            
    
            Console.ReadLine();

        }
    }
}
