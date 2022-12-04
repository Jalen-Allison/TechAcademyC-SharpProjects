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
            //TwentyOneGame game = new TwentyOneGame();                           // inherted from "Game" in the "TwentyOneGame" class
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };       // inheriting from "Game" gives access to "Players" //{"names in curly brackets"} is instantiating with values. (value = the names)
            //game.ListPlayer();                                                   // called the "super class method method" called the method from the class inherited from
            //game.Play();                                           
            //Console.ReadLine();

            //List<Game> games = new List<Game>();  //polymorphism = ability of a class to morph into its inheriting class that give certain advantanges
            //TwentyOneGame game = new TwentyOneGame();
            //games.Add(game);


            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();

            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game += player;  //overloading operators
            game -= player;

            Deck deck = new Deck();                 //created object "deck
            deck.Shuffle(3);                        //Calls the Shuffle method then it shuffles the deck (amount of times requested) and returns it back to the deck 


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);    //counts how many cards are made 
            Console.ReadLine();
        }
    }
}
