using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            School student = new School(); //instaniating the class (also the object)
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(student.Adding(userInput)); //calling the method and passing in the user input 
            

            Console.WriteLine(student.Subtraction(userInput));

            Console.WriteLine(student.Multiplying(userInput));

            Console.ReadLine();


        }
    }
}
