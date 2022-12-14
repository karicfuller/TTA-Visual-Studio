using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino._21_Game
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } } //property common to all games
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        //public string Dealer { get; set; }

        public abstract void Play(); //abstract method

        public virtual void ListPlayers() //virtual method inside abstract class=this method gets inherited but has ability to override
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
