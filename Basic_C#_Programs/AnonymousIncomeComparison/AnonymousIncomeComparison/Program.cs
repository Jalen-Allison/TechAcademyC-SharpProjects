using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate?");
            int hourly = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate?");
            int hourly2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            int product = (hourly * hoursWorked * 52);
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2:");
            int product2 = (hourly2 * hoursWorked2 * 52);
            Console.WriteLine(product2);
            Console.ReadLine();

            Console.WriteLine("Does person 1 make more money than person 2?");
            bool trueOrFalse = product > product2;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

        }
    }
}

    

