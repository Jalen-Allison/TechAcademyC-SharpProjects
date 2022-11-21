using System;
using System.Collections.Generic;




    class Program
    {
        static void Main(string[] args)
        {
           
            int[] nArray = { 21, 22, 55, 11, 88 };
            Console.WriteLine("Select an int index of the array; (0-4) ");
        

            int index = int.Parse(Console.ReadLine());
        if (index < 5)
        {


            Console.WriteLine("value is: " + nArray[index]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("This is not an option.");
        }

            string[] names = { "Bob", "Joey", "Arty" };
            Console.WriteLine("Select a string index of the array; (0-2) ");
        //int number2 = Convert.ToInt32(Console.ReadLine());
        //bool isArray2 = number2 < 2;
        //Console.WriteLine("That is not an option");

        int nIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("value is: " + names[nIndex]);
            Console.ReadLine();

            List<string> sList = new List<string>();
            sList.Add("Dog");
            sList.Add("Cat");
            Console.WriteLine("Select an String index of the list; (0-1) ");
        //int name1 = Convert.ToInt32(Console.ReadLine());
        //bool isArray3 = name1 < 1;
        //Console.WriteLine("That is not an option");

        int sIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("value is: " + sList[sIndex]);
            Console.ReadLine();


      

        }
    }

