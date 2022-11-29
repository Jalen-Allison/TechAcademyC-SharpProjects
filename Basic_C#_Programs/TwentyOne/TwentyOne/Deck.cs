using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() //constructor (a method thats called as soon as an object is created 
        {
            Cards = new List<Card>(); //instantiate its property (Cards) as an empty list of cards
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {                                           //loops through each face card 4 times since theres four different suits 
                foreach (string suit in Suits) 
                {
                    Card card = new Card(); //during each loop, it creates a card 
                    card.Suit = suit; //assign the suit property 
                    card.Face = face; //assign the face property
                    Cards.Add(card);  //adds new card that was created into the card list at the top 
                }
            }


        }
        public List<Card> Cards { get; set; }
    }
}
