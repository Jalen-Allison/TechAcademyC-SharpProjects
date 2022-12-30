using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.Write("Enter student name: ");
                var userInput = Console.ReadLine();

                var student = new Student { StudentName = userInput };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from b in db.Students orderby b.StudentName select b;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual List<Student> Students { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}