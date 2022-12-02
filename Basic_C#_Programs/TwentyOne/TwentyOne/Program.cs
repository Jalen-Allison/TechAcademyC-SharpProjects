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
            TwentyOneGame game = new TwentyOneGame();                           // inherted from "Game" in the "TwentyOneGame" class
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };       // inheriting from "Game" gives access to "Players" //{"names in curly brackets"} is instantiating with values. (value = the names)
            game.ListPlayer();                                                   // called the "super class method method" called the method from the class inherited from
            game.Play();                                           
            Console.ReadLine();


            // created object "deck"
            //Deck deck = new Deck(); 
            //deck.Shuffle(3);                        //Calls the Shuffle method then it shuffles the deck (amount of times requested) and returns it back to the deck 
            

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);    //counts how many cards are made 
            //Console.ReadLine();
        }
    }
}
