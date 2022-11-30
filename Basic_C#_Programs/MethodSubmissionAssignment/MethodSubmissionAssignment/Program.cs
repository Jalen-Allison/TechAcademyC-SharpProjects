using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            numberS digits = new numberS(); //instantiating the class

            Console.WriteLine("Input two numbers. One at a time. You can leave the second number blank if you'd like.");
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Enter first number");
            int userInput = Convert.ToInt32(Console.ReadLine()); 

            try //contains code that may contain an exception

            {

                
                Console.WriteLine("Enter second number or leave blank");
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                
                Console.WriteLine("Adding your two numbers... Results:");
                Console.WriteLine(digits.Adding(userInput, userInput2)); //Calls the method to return the added inputs of userInput and userInput 1 if neither entry is left blank
                

            }
            catch //exception is thrown because userInput2 left the second number blank. This handles it 
            {
                Console.WriteLine("You've choosen to only pick 1 number. Which is:");
                Console.WriteLine(digits.Adding(userInput)); //Calls the method since second option was left blank which is = to 0, inturn only showing the first UserInput number
            }

            Console.ReadLine();
        }
    }
}
