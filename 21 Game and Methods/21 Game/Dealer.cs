using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Game
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) //Deal method
        {
            Hand.Add(Deck.Cards.First()); //taking first card and add to hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //writing to console card about to put in deck
            Deck.Cards.RemoveAt(0);
        }
    }
}
