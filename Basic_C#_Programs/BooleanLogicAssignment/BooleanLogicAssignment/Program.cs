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

            bool qualified = (age > 15 && ticket == false && speeding <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();

            //bool age = (age > 15);
            //Console.WriteLine(ofAge);

            ////bool DUI = (ticket == 0);
            ////Console.WriteLine(DUI);

            //bool speed = (3 <= speeding);
            //Console.WriteLine(speed);



        }
    }
}
