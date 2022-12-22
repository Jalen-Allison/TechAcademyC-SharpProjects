using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        //action result is used to return the models to the Views, file streams, and also redirect to the controllers 
        public ActionResult Index()                 
        {
            return View();
        }

        [HttpPost]          //post carries changes in the database
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;Integrated Security=True;Connect 
                                          Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; //Connection String  is required to connect an MVC application to a database

                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) Values
                                        (@FirstName, @LastName, @EmailAdress)";

                using (SqlConnection connection = new SqlConnection(connectionString))   //  Using Statement help prevent SQL injections so connections to databases should be wrapped in one
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}