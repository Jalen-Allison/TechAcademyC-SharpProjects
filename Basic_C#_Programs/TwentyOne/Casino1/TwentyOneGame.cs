using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino1.Interfaces;

namespace Casino1.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway  //inheriting the class "Game"  //interface = "IWalkAway" allows multiple inheritances or interfaces
    {
        public TwentyOneDealer Dealer { get; set; }
        //Play method
        public override void Play() // override allows you to implement Play since Game is abstract, tells computer we will define this method  
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)                                         //instantiating | Players 
            {
                player.Hand = new List<Card>();                                       //Makes hand blank so you dont carry over the old hand
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();


            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0; 
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }
                if (bet < 0)
                {
                    throw new FraudException("Security! Kick this person out.");
                }
                bool succesfullyBet = player.Bet(bet);
                if (!succesfullyBet)                                                    // ! = false same as (... == false)
                {
                    return;                                                         //means end this methhod. Doesnt return anything 
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Players)
                {
                    Console.Write("{0}:", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)                                                //means second turn | checking for blackjack
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0}", card.ToString());
                        {
                            Console.WriteLine("\n\nHit or stay?");
                            string answer = Console.ReadLine().ToLower();
                            {
                                if (answer == "stay")
                                {
                                    player.Stay = true;
                                    break;
                                }
                                else if (answer == "hit")
                                {
                                    Dealer.Deal(player.Hand);
                                }
                                bool busted = TwentyOneRules.IsBusted(player.Hand);
                                if (busted)
                                {
                                    Dealer.Balance += Bets[player];
                                    Console.WriteLine("{0} Busted! You lose your bet {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                                    Console.WriteLine("Do you want to play again?");
                                    answer = Console.ReadLine().ToLower();
                                    if (answer == "yes" || answer == "yeah")
                                    {
                                        player.isActivelyPlaying = true;
                                        return;
                                    }
                                    else
                                    {
                                        player.isActivelyPlaying = false;
                                        return;
                                    }

                                }
                            }
                        }
                    }
                }
            }
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
                while (!Dealer.Stay && !Dealer.isBusted)
                {
                    Console.WriteLine("Dealer is hitting...");
                    Dealer.Deal(Dealer.Hand);                                                   //deals dealer a card
                    Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                    Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
                }
                if (Dealer.Stay)
                {
                    Console.WriteLine("Dealer is staying.");
                }
                if (Dealer.isBusted)
                {
                    Console.WriteLine("Dealer Busted!");
                    foreach (KeyValuePair<Player, int> entry in Bets)                           //loops through  key value pairs (a collection of key value pairs is a Dictionary)
                    {
                        Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);         //accesing the values in the KeyValuePair
                        Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);  //Where produces a list, get list of player where their name = a name in the dictionary.
                                                                                                            //Giving them their money back x2 because they won
                        Dealer.Balance -= entry.Value;
                    }
                    return;
                }
                foreach (Player player in Players)
                {
                    bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);                                                         //means a bool can be null 
                    if (playerWon == null)
                    {
                        Console.WriteLine("Push! No one wins.");
                        player.Balance += Bets[player];

                    }
                    else if (playerWon == true)
                    {
                        Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                        player.Balance += (Bets[player] * 2);
                        Dealer.Balance -= Bets[player];

                    }
                    else
                    {
                        Console.WriteLine("Dealer wins {0}!", Bets[player]);
                        Dealer.Balance += Bets[player];                                                 //bets player is the key that opens up the value 


                    }
                    Console.WriteLine("Play again?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes" || answer == "yeah")
                    {
                        player.isActivelyPlaying = true;
                    }
                    else
                    {
                        player.isActivelyPlaying = false;
                    }

                }

        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player) 
        {
            throw new NotImplementedException();
        }
    }
}
