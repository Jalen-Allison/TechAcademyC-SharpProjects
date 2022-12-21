using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Casino1;
using Casino1.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Casino1Name = "Grand Hotel and Casino"; 

           // Guid identifier = Guid.NewGuid();  // a globally unique identifier

            Console.WriteLine("Welcome to the {0} Let's start by telling me your name.", Casino1Name);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();

                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //cast it from string to int.
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya") //checks the users input answers for these possible versions of yes 
            {
                Player player = new Player(playerName, bank);                       //creating new player object and initailizing the person
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\jalen\Logs\log.txt", true))      //logging everytime a card is dealt | true = append the text to the file 
                {
                    file.WriteLine(player.Id);           //logs the exact time a player decided to play and the cards he had                   
                }
                Game game = new TwentyOneGame();                                    //polymorphism so it exposes overloaded operators
                game += player;                                                     //adding a new player to the game
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)               //checks if the player wants to keep playing and do they have enough money to keep playing. If those two conditions are met, the while loop will continue
                                                                                     //if they say no then it skips the if and jumps to "bye for now" stataement 
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An eroor occured. Please contact your system admin");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            //ADO.NET = a portion of the base class library that assists with communicating with a SQL database.
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; Integrated Security = True; 
                                      Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                      MultiSubnetFailover = False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES                      
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";                                   // protects from SQL Injection so it checks what user said before mapping into the query

            using (SqlConnection connection = new SqlConnection(connectionString))                                     // a way to control unmanaged code/resources/memory when dealing with extrernal resources 
                                                                                                                       // once we exit the last curly brace, it automatiacally shuts off that resource
            {
                SqlCommand command = new SqlCommand(queryString, connection);                                           
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; Integrated Security = True; 
                                      Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                      MultiSubnetFailover = False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);


                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())                                   //loops thru each record were getting back 
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }

            return Exceptions;
        }
    }
}






                                                //different learned functions throughout building the game but ended up not using 

            //  File.WriteAllText(@"C:\Users\jalen\Logs\log.txt", text);  
            // string text = File.ReadAllText(@"C:\Users\jalen\Logs\log.txt");

                //Deck deck = new Deck();                 //created object "deck"


                //deck.Shuffle(3);                        //Calls the Shuffle method then it shuffles the deck (amount of times requested) and returns it back to the deck 


                //    foreach (Card card in deck.Cards)
                //    {
                //        Console.WriteLine(card.Face + " of " + card.Suit);
                //    }
                //    Console.WriteLine(deck.Cards.Count);    //counts how many cards are made 
                //Console.ReadLine();
            
               // int count = deck.Cards.Count(X => x.Face == Face.Ace); //counting all the elements (represented by x) where x.face = face.ace LAMBDA

               // List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); // take the list of cards and find out where the face equals the King and map that to a new list. 

                //foreach (Card card in newList) //took deck of cards populated above, and created a newList with just Kings
                //    {
                //        Console.WriteLine(card.Face);
                //    }

                //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
                //int sum = numberList.Where(x => x > 20).Sum(); //foreach item, where(creates new list) the items is bigger than 20 add the sum

                //Console.WriteLine(sum);


 //Card card = new Card();
            //card.Suit = Suit.Clubs; //enum allows to limit possible values
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);

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