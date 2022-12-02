using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }



        public void SayName() // void = doesnt return anything
        {
           
            {
                Console.WriteLine("Name:" + this.FirstName + " " + this.LastName); // will print this sentence to the console once "SayName()" is called
            }
        }
    }

    
}
