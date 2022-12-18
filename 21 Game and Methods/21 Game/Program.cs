using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino._21_Game;

namespace _21_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            ////INSTANTIATION
            //Game game = new Game();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" }; //inherited from game class, have access to Players properties
            //game.ListPlayers(); //inherited from  class, have access to ListPlayers method
            //Console.ReadLine();

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>(); //instantiated list
            //Player player = new Player(); //create a new player
            //player.Name = "Jesse"; //give player a name
            //game += player; //game + player and returns a game/method that returns a game
            //game -= player;

            //Card card = new Card(); //new card object
            //card.Suit = Suit.Clubs; //gives enum value options
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds); //convert string to int
            //Console.WriteLine(underlyingValue); //display value or index of Diamonds

            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);

            //int count = deck.Cards.Count( x => x.Face == Face.Ace);

            //string text = "Here is some text"; //written text
            //File.WriteAllText(@"C:\Users\Kari Fuller\Desktop\log.txt", text); //write text
            //string text = File.ReadAllText(@"C:\Users\Kari Fuller\Desktop\log.txt"); //read text

            //DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);

            const string casinoName = "Grand Hotel and Casino";

            Guid identifier = Guid.NewGuid();

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
    }
}
//inheritance is an is/a relationship, not a has/a relationship, then class property (if unsure, use property).
//abstract class can never be an object. Only meant to be inherited from.
//abstract method can only exist inside an abstract class/any class inheriting the abstract class, must inherit the method.
//abstract method contains no implementation
//can inherit multiple interfaces