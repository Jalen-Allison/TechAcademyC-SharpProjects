using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
                Console.WriteLine("Enter current day of the week");
                string userInput = Console.ReadLine();
                DaysOfWeek days = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek),userInput); //Assigned the "DaysOfWeek" value to the variable "days" of the enum data type
                                                                                        //and parses through DaysOfWeek to see if the user input correlates with one of
                                                                                        //the enums
                Console.WriteLine("The current day is " + userInput);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Please enter an actual day of the week."); 
            }



            Console.ReadLine();

        }

    }
}
