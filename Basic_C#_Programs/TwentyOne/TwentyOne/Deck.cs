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

            for (int i = 0; i < 13; i++)  // 13 faces
            {
                for (int j = 0; j < 4; j++)  // 4 faces | Going to loop 52 times "13*4 = 52" 52 cards in a deck
                {
                    Card card = new Card(); //creates a new card each time
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1) 
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0) // adds and deletes cards until there are no cards left
                {
                    int randomIndex = random.Next(0, Cards.Count); // take minValue and mxValue and returns a random integer that is within a specificied range
                    TempList.Add(Cards[randomIndex]); //add that number to a temporary list 
                    Cards.RemoveAt(randomIndex); // deletes from list of cards 
                }
                Cards = TempList; 
            }

        }
    }
}




//List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
//List<string> Faces = new List<string>()
//{
//    "Two", "Three", "Four", "Five", "Six", "Seven",
//    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
//};

//foreach (string face in Faces)
//{                                           //loops through each face card 4 times since theres four different suits 
//    //foreach (string suit in Suits) 
//    //{
//    //    Card card = new Card(); //during each loop, it creates a card 
//    //    card.Suit = suit; //assign the suit property 
//    //    card.Face = face; //assign the face property
//    //    Cards.Add(card);  //adds new card that was created into the card list at the top 
//    //}
//}