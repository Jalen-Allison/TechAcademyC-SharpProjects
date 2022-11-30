using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssigment
{
    public class Work
    {
        // The three methods with same name but doing different math operations 
        public int Adding(int num) //takes an integer
        {
            Console.WriteLine("This is the integer method");
            return num + 3;

        }

        public int Adding(decimal num) // takes a decimal but allows for the same name and different math operation
        {
            int dec = Convert.ToInt32(num); //declaring "dec" and conveerting it to an int  (determines the name and data type of a variable)
            Console.WriteLine("This is the decimal method");
            return dec - 7;
        }

        public int Adding(string num) // takes a string but allows for the same name and different math operation
        {
            int str = Convert.ToInt32(num); //declaring the string and converting it to an int (determines the name and data type of a variable)
            Console.WriteLine("This is the string method");
            return str * 3;
        }
    }
}
