using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino1 {   

    public abstract class Game //abstract class can nver be instantiated
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }


        public abstract void Play();

        public virtual void ListPlayers()               // virtual method inside of an abstarct class is that this method gets inherited by an inhyereiting class but it can overrride it  
                                                       //doesnt return anything just printing to the console
        {
            foreach (Player player in Players)  //loops through the player property above
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
