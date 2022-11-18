using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");


            Console.WriteLine("Please enter package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else if (weight <= 50)
            {
                Console.WriteLine("Please enter package height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                int total = (height + length + width);
                int price = (height * width * length * weight / 100);
                if (total > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else if (total <= 50)
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + price + ".00" + "Thank You!");
                    Console.ReadLine();


                }
            }
        }
    }
}
