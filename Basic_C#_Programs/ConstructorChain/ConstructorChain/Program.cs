using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            var Employee = "Jalen";

            const string jobName = "The Tech Academy";
        }



        public class NewEmployee
        {
            public int id { get; set; }
            public string lastName { get; set; }


            public NewEmployee(int id, string lastName) //1st constructor 
            {
                this.id = id;
                this.lastName = lastName;
            }
            public NewEmployee(int id) : this(id, "")  //2nd constructor 
            {
            }
            public NewEmployee(string lastName) : this(0, lastName) //chaining the two constructs together
            {
            }
        }
    }
}
