using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringandIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<int> numbers = new List<int>(); //creates a list if numbers
                numbers.Add(10);
                numbers.Add(20);
                numbers.Add(2);
                numbers.Add(4);

            //contains the guarded code that may cause an exception. The block is executed until an exception is thrown or it is completed successfully
            try
            {
                    Console.WriteLine("Pick a whole number and I will divide it by 10, 20, 2 and 4");
                    int firstNum = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < numbers.Count; i++)  // iterates through the "numbers" list
                    {
                        Console.WriteLine(numbers[i] / firstNum); //divides the numbers in the list starting from index 0 (int i = 0), by the users input(firstNum)
                    }
                    
                }
            // When an exception is thrown, the common language runtime (CLR) looks for the catch statement that handles the exception
            catch (FormatException ex)
            {
                Console.WriteLine("please type a whole number");
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("please dont divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally // execute this code whether an exception is thrown or not thrown
            {
                Console.WriteLine("The program has resumed after the try/catch block");
                Console.ReadLine();
            }









        }
    }
}
