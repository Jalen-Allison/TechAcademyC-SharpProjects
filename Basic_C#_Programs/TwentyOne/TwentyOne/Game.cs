using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //abstract class can nver be instantiated
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();

        public virtual void ListPlayers()               // virtual method inside of an abstarct class is that this method gets inherited by an inhyereiting class but it can overrride it  
                                                       //doesnt return anything just printing to the console
        {
            foreach (string player in Players)  //loops through the player property above
            {
                Console.WriteLine(player);
            }
        }
    }
}
