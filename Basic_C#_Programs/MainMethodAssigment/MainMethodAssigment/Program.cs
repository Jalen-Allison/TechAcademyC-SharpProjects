using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Work employee = new Work(); //instaniating the class (also the object)

            Console.WriteLine(employee.Adding(6)); //calling the method and adding 6 to it


            Console.WriteLine(employee.Adding(4.7m)); //calling the method and substracting 4.7 to it (rounds to the nearest whole number)


            Console.WriteLine(employee.Adding("7")); //calling the method and changing the string "7" to an int so it can do the multiplication operation  

            Console.ReadLine();

          
        }

    }
}
