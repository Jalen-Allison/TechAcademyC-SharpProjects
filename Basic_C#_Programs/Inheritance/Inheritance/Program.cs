using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee label = new Employee() { FirstName = "Sample", LastName = "Student"}; //  instantiates and initializes an Employee object
            label.SayName();                // Calls the superclass method inside of the superclass "Person" to print the sentence to console
            Console.ReadLine();
            
        }
    }
}
