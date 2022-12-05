using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();  //Calls the SayName() method on the object. 
            IQuittable quittable = new Employee(); // Employee is inheriting from the IQuittable class using polymorphism
            quittable.Quit();
            Console.ReadLine();

            

            
        }
    }
}
