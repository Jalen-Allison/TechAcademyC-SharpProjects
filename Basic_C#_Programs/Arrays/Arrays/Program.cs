using System;
using System.Collections.Generic;




    class Program
    {
    static void Main(string[] args)
    {

        int[] nArray = { 21, 22, 55, 11, 88 };    
        Console.WriteLine("Select an int index of the array; (0-4) ");


        int index = int.Parse(Console.ReadLine());         // allows the program to search for specific numbers in the index
        if (index < 5)
        {
            Console.WriteLine("value is: " + nArray[index]);        //displays the correlating number in array if number choosen was between 0-4 
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("This is not an option.");          // if number that is not less than 5 is picked. This message is shown 
        }


        string[] names = { "Bob", "Joey", "Arty" };
        Console.WriteLine("Select a string index of the array; (0-2) ");


        int nIndex = int.Parse(Console.ReadLine());
        if (nIndex < 2)
        {
            Console.WriteLine("value is: " + names[nIndex]);
            Console.ReadLine();
        }
        else
        { 
            Console.WriteLine("This is not an option.");
        }

        List<string> sList = new List<string>();
            sList.Add("Dog");
            sList.Add("Cat");
            Console.WriteLine("Select an String index of the list; (0-1) ");
        

        int sIndex = int.Parse(Console.ReadLine());
        if (sIndex < 1)
        {
            Console.WriteLine("value is: " + sList[sIndex]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("This is not an option.");
        }




    }
}

