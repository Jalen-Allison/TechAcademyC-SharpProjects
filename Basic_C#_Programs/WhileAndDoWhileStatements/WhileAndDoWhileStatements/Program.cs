using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDoWhileStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's Tom Bradys number?");
            int guess = Convert.ToInt32(Console.ReadLine());
            bool isHunch = guess == 12;   //if guess is false keep looping

            do        // executes the code block once, before checking if the condition is true, then it will repeat the loop as
                      // as its true
            {
                    switch (guess)    //value of the expression is compared with the values of each case
                                      //if there is a match, the associated block of code is executed
                    {
                        case 13:
                            Console.WriteLine("Close, but wrong.");
                            Console.WriteLine("What's Tom Bradys number?");
                            guess = Convert.ToInt32(Console.ReadLine());
                            break;                                        //allows program to ignore the execution of all the rest of code in the switch block if the condition is met at that point
                        case 12:
                            Console.WriteLine("Congrats! You guessed TB12's number.");
                            isHunch = true;  // lets the program know that you've guessed the correct number
                            break;
                        default:                                           // what happens when none of other cases evaluate to true 
                            Console.WriteLine("Nope, try again.");
                            Console.WriteLine("What's Tom Bradys number?");
                            guess = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!isHunch);   // keeps looping asking you to guess until you get it correct

                Console.Read();
        }
    }
}
