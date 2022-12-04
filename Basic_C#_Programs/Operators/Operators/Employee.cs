namespace Operators
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee FirstName, Employee LastName)

            {
            if (FirstName.Equals(LastName))
                return true;
            else
                return false;
            
            }

        public static bool operator !=(Employee FirstName, Employee LastName)

        {
            if (FirstName.Equals(LastName))
                return true;
            else
                return false;
        }


        //public static Employee operator ==(Employee FirstName, Employee LastName)

        //{
        //    return FirstName == LastName;

        //}

        //public static Employee operator !=(Employee FirstName, Employee LastName)

        //{
        //    return FirstName != LastName;
        //}






        //    public static Employee operator !=(Employee employee1, Employee employee2)
        //    {
        //        return employee1 != employee2;
        //    }
        //}



    }
