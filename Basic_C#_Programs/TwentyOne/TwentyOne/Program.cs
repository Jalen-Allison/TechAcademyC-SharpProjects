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

            //Card card = new Card();
            //card.Suit = Suit.Clubs; //enum allows to limit possible values
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);



                Deck deck = new Deck();                 //created object "deck"
               // int count = deck.Cards.Count(X => x.Face == Face.Ace); //counting all the elements (represented by x) where x.face = face.ace

               // List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); // take the list of cards and find out where the face equals the King and map that to a new list. 

                //foreach (Card card in newList) //took deck of cards populated above, and created a newList with just Kings
                //    {
                //        Console.WriteLine(card.Face);
                //    }

                //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
                //int sum = numberList.Where(x => x > 20).Sum(); //foreach item, where(creates new list) the items is bigger than 20 add the sum

                //Console.WriteLine(sum);

                deck.Shuffle(3);                        //Calls the Shuffle method then it shuffles the deck (amount of times requested) and returns it back to the deck 


                //    foreach (Card card in deck.Cards)
                //    {
                //        Console.WriteLine(card.Face + " of " + card.Suit);
                //    }
                //    Console.WriteLine(deck.Cards.Count);    //counts how many cards are made 
                Console.ReadLine();
            
        }
    }
}



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

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;  //overloading operators
            //game -= player;