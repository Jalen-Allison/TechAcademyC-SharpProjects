using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math number = new Math(); //Instantiates the class

            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine()); //allows user input to be converted and stored

            number.Divide(userInput); // calls the method to Divide user input by 2
            Console.WriteLine(number.Result); //displays the results

            number.Divide(userInput, 2); // divides userInput by 2
            Console.WriteLine(number.Result);

            Console.WriteLine("Enter a phrase: ");
            string input = Console.ReadLine(); //allows user input to be converted and stored
            string sentence = number.StringCounter(input, out int count); // calls method and allows user to input then "out" throws the variable "count" which counts the length of the phrase
            Console.WriteLine(sentence);

            Console.ReadLine();
        }
    }
}
