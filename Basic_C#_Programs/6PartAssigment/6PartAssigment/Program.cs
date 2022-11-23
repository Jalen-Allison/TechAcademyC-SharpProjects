using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PartAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assingment Part 1
            //One dimensional array of strings
            string[] names = { "Saints", "Chargers", "Vikings" };           // makes an array
            Console.WriteLine("Whats your favorite NFL team?");


            string input = Console.ReadLine();    // allows program to store users input

            for (int i = 0; i < names.Length; i++)   // A loop that iterates through each string in the array and adds the user's text input to the end of each string. 
                                                     // iterates through index and adds 1 until it reaches the total string amount in the array

            {
                string NFL = names[i] + " " + input;   //will update each array element by appending the user's text.
                names[i] = NFL;

            }
            foreach (string team in names)         // prints off each string in the array one at a time 
            {
                Console.WriteLine(team);
            }

            Console.ReadLine();



            //Assingment Part 2

            // Creating infinite loop
            //for (int i = 0; ; i++)   // theres no ending point in the loop

            //Fixing infinite loop
            for (int i = 0; i <= 10; i++)         // added "i <=10" lets the program know to stop once it reaches 10 
            {

                Console.WriteLine(i + " , ");     //prints each number until its = to 10
            }
            Console.ReadLine();




            //Assingment Part 3
            //Comparison operators

            for (int i = 0; i < 10; i++)       // stops loop once number is bigger than 9
            {
                Console.WriteLine(i + "");         //prints numbers 
            }
            Console.ReadLine();

            for (int i = 0; i <= 5; i++)             //stops loop once number is = to or smaller than 5
            {
                Console.WriteLine(i + "");          // prints numbers
            }
            Console.ReadLine();


            //Assingment Part 4
            //list of strings 

            List<string> animals = new List<string>() { "Dog", "Cats", "Bird", "Snake" };    // makes a list
            Console.WriteLine("Please write Dog, Cats, Bird or Snake ");
            string enter = Console.ReadLine();       //allows user to enter and be stored 

            if (animals.Contains(enter))      // determines whether what the user entered is in the list
            {
                for (
                    int i = 0; i < animals.Count; i++)       //iterates through list 
                {
                    string input2 = animals[i];               // lets program know that the input should be = to one of the animals in list

                    if (input2 == enter)                     //  checks to see if user input is = to one of the animals in list
                    {

                        Console.WriteLine("Match index: " + i);          // shows where the index is for what user enters if within list
                    }

                }
            }
            else
            {
                Console.Write("Error: That wasnt one of the names.");         // if user types an animal that isnt in list they get this error message
            }

            Console.ReadLine();



            //Assignment 5   
            List<string> NBAteams = new List<string>() { "Warriors", "Warriors", "Hornets", "Lakers" };     // makes a list
            Console.WriteLine("Please write Warriors, Lakers, Hornets to find index in list");       
            string select = Console.ReadLine();

            if (NBAteams.Contains(select))                    // determines whether what the user entered is in the list
            {
                for (int i = 0; i < NBAteams.Count; i++)     // iterates through list 
                {
                    string match = NBAteams[i];              // lets program know that the input should be = to one of the NBAteams in list

                    if (match == select)                    // checks to see if user input is = to one of the NBAteam in list
                    {
                        Console.WriteLine(select + " Index Place = " + i);    //  shows what the user entered and where the index is for what user enters if within list
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: Input is not on the list.");       // if user types a team that isnt in list they get this error message
            }
                
                Console.ReadLine();

            //Assignment 6
            List<string> CompLang = new List<string>() { "C#", "JavaScript", "Python", "Python" };
            List<string> Duplicate = new List<string>();   // a new empty list to add the languages into so we can check for a duplicate   
            {
                foreach (string Lang in CompLang)       // loops through list 

                    {
                            if (Duplicate.Contains(Lang))           //determines if the duplicate list has elements that "Lang" has
                            {

                            {
                                Console.WriteLine(Lang + " - this item is not unique");   // if there is a duplicate it will print this 
                                    
                            }

                            }
                            else
                            {
                                
                                Console.WriteLine(Lang + " = this item is unique");    // if theres no duplicate it will print this 
                            }
                            Duplicate.Add(Lang);       // loops through then adds language 1 at a time to duplicate list triggering the if else statements

                }
            }
            Console.ReadLine();

        }

    }
}
