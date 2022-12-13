using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; // Gets the current date and time
            Console.WriteLine(now);  // Prints the current date and time to the console.


            Console.WriteLine("Please enter a number.");
            int uInput = Convert.ToInt32(Console.ReadLine());
            DateTime uTime = now.AddHours(uInput); // takes the user input and adds it to the current date time hours

            Console.WriteLine(uTime); // prints what time it will be from user input 
            Console.ReadLine();


        }
    }
}
