using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {


  

            List<Employee> employeeList = new List<Employee>()
           {
               new Employee() {FirstName = "Rebecca", LastName = "Smith", Id = 1 },
               new Employee() {FirstName = "Chloe", LastName = "Smith", Id = 2 },
               new Employee() {FirstName = "Jay", LastName = "Smith", Id = 3},
               new Employee() {FirstName = "Kait", LastName = "Smith", Id = 4},
               new Employee() {FirstName = "Amber", LastName = "Smith", Id = 5},
               new Employee() {FirstName = "Darrell", LastName = "Smith", Id = 6},
               new Employee() {FirstName = "Joe", LastName = "Smith", Id = 7 },
               new Employee() {FirstName = "Sarah", LastName = "Smith", Id = 8},
               new Employee() {FirstName ="Joe" , LastName = "Smith", Id = 9},
               new Employee() {FirstName = "John", LastName = "Smith", Id = 10},
           };


            //loops through and creates new list of all the employees with the first name "Joe"
            List<Employee> employees = new List<Employee>(); // makes new list
            foreach (Employee people in employeeList)        //loops through employeeList
            {
                if (people.FirstName == "Joe")               //if first name is Joe
                {
                    employees.Add(people);                   //add them to new list
                }
                
            }

            List<Employee> LAMBDAlist = employeeList.Where(x => x.FirstName == "Joe").ToList(); //New  list is named LAMBDAlist and it searches for first names == to "Joe" in the original "employeeList" using the Where function 
                                                                                                //and the comparison statement. "ToList()" maps what is being asked in statement to a new list


            List<Employee> LAMBDAlist2 = employeeList.Where(x => x.Id > 5).ToList();            //New  list is named LAMBDAlist2 and it searches for all employees with an Id number greater than 5 in orgial "employeeList" using the 
                                                                                                //where function and x > 5 statement. "ToList()" maps what is being asked in statement to a new list
        }

    }
}
