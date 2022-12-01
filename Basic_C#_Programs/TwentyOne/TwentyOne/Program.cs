using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); // created object "deck"
            deck.Shuffle(3); //Calls the Shuffle method then it shuffles the deck (amount of times requested) and returns it back to the deck 
            

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count); //counts how many cards are made 
            Console.ReadLine();
        }
    }
}
