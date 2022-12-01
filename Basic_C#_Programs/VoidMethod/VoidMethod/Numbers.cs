using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Numbers
    {
        public void Add(int num1, int num2) //takes two integers as parameters
        {
            int results = num1 + 2; //does a math operation (but wont be called)
            Console.WriteLine("The second integer is " + num2); //displays the second integer to the screen

        }
    }
}
