using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)                            //pass in a Hand, it takes whichever the first card is in its deck and inserts it into the Hand 
        {
            ///Adds first item, prints it to the console and removes it from the deck 
            Hand.Add(Deck.Cards.First());                            //(First = a method available to a list which takes the first item in that list)  //grabs first card, and it adds it to the Hand that is passed in to deal
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); // prints which card was dealt to the console 
            Deck.Cards.RemoveAt(0);                                       // Remove at = a method that any list has, that passes in an index that you want to remove 
        }
    }
}
