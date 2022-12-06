namespace Operators
{
    class Employee
    {
        //properties
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public int Id { get; set; }


                                                //employee1 and employee2 = parameters
        public static bool operator ==(Employee employee1, Employee employee2)  //using bool (= the return type) so program can return true or false based off the employee Id 
                                                                                //overloaded the "==" to allow the ability to use the "==" operator to compare the two objects once they are instantiated in the main Program
        {

            return employee1.Id == employee2.Id;                //reutrns true or false based off the IDs being the same

        }




        public static bool operator !=(Employee employee1, Employee employee2)  //comparison operators must be overloaded in pairs 
        {
            return employee1.Id != employee2.Id;                //reutrns true or false based off the IDs being different
        }
    }
}



