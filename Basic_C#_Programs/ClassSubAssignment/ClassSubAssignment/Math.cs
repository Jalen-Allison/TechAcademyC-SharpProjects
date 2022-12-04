using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubAssignment
{
    public class Math
    {
        public int Result { get; set; }
        public void Divide(int num1)  //void method
        {
            Console.WriteLine("This is method 1");
            Result = num1 / 2;
        }

        public void Divide(int num1, int num2)  //overloading the "Divide" method but having it divide by a set integer in "Program.cs"
        {
            Console.WriteLine("This is method 2");
            Result = num1 / num2;
            Result = num1 / num2;
        }



        //method with output parameters
        public string StringCounter(string word, out int count) //count is what is being outputted
        {
            count = word.Length; //counts how many letters are being counted 
            string phrase = "Your word is: " + count + " letters long";
            return phrase; //prints phrase
        }
    }
}
