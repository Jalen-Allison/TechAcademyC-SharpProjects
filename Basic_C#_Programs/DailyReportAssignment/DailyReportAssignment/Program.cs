using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");   //using string data type
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());   //using integer data type

            string userInput;
            Console.WriteLine("Do you need help with anything? Please answer true or false");
            userInput = Console.ReadLine();

            bool userInputBoolean = Convert.ToBoolean(userInput);

            bool isHelp = true;
            bool isNoHelp = false;      //Using boolean data type

           

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string review = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            string end = Console.ReadLine();


            



        }
    }
}
