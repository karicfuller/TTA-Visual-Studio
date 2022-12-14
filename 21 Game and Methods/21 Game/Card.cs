using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Game
{
    public struct Card //change from class to struct
    {
        public Suit Suit { get; set; }  //public = accessible to other parts of program
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }

    }
    public enum Suit //name of enum class
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six, 
        Seven,
        Eight,
        Nine,
        Ten, 
        Jack,
        Queen, 
        King,
        Ace
    }
}
