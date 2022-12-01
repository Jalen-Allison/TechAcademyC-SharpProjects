using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Have you ever had a DUI?");
            bool ticket = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int speeding = Convert.ToInt32(Console.ReadLine());

            bool qualified = (age > 15 && ticket == false && speeding <= 3);   // To be qualified user has to be over the age of 15, No DUI's, and can have no more than 3 speeding tickets.
                                                                               // If meet the criteria, will respond with true
            Console.WriteLine(qualified);
            Console.ReadLine();


        }
    }
}
