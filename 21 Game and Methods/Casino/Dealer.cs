using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino._21_Game
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) //Deal method
        {
            Hand.Add(Deck.Cards.First()); //taking first card and add to hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); //writing to console card about to put in deck
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Kari Fuller\Desktop\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
