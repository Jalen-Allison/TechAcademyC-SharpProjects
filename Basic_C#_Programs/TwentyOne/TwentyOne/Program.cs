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
            Deck deck = new Deck();
            deck = Shuffle(deck); //Calls the Shuffle method then it shuffles the deck and returns it back to the deck 

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count); //counts how many cards are made 
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck) // Method/function
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0) // adds and deletes cards until there are no cards left
            {
                int randomIndex = random.Next(0, deck.Cards.Count); // take minValue and mxValue and returns a random integer that is within a specificied range
                TempList.Add(deck.Cards[randomIndex]); //add that number to a temporary list 
                deck.Cards.RemoveAt(randomIndex); // deletes from list of cards 
            }
            deck.Cards = TempList;
            return deck;


        }
    }
}
