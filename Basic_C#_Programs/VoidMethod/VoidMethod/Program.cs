using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers figure = new Numbers(); //instantiate the class/object

            figure.Add(3,4); //calls method but only displays second number 

            figure.Add(num1: 6, num2: 8); //calls method by parameters name but only displays second number

            Console.ReadLine();

        }
    }
}
