using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person, IQuittable  //inheriting from Person class  //IQuittable is the interface, allows multiple inheritances
    {
        public override void SayName()    //have to override to implement 
        {
            Console.WriteLine(this.firstName + " " + this.lastName);   // will print this sentence to the console once "SayName()" is called |||  
                                                                       //.this refers to the current class instance/refers to the object through which its containing method or property was invoked
        }
        public void Quit()
        {
            Console.WriteLine("Hit enter to quit"); //implementing the interface
        }
    }
}
