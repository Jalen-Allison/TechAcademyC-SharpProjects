using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee() { FirstName = "John", LastName = "Doe", Id = 1 }; //instantiating first and last name and Id
            Employee employee2 = new Employee() { FirstName = "Jane", LastName = "Doh", Id = 2 };


            Console.WriteLine(employee1 == employee2); //comparing the two Employee objects using the overloaded operators and will write true or false since its a bool
            Console.WriteLine(employee1 != employee2);






            Console.ReadLine();

        }
    }
}
