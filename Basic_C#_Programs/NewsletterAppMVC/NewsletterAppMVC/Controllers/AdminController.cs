using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())          //instiantes newletter enity object that gives access to the database
            {
             // var signups = db.SignUps.Where(x => x.Removed == null).ToList();                                    //lamdba syntax   //created variable signups that is equal to all the records within the SignUps database
                var signups = (from c in db.SignUps                                                                     //link = language intergerated query
                               where c.Removed == null
                               select c).ToList();

                var signupVMs = new List<SignupVM>();
                foreach (var signup in signups)                                 //mapping the viewmodels from the models to the viewmodels 
                {
                    var signupVM = new SignupVM();
                    signupVM.Id = signup.Id;
                    signupVM.FirstName = signup.FirstName;
                    signupVM.LastName = signup.LastName;
                    signupVM.EmailAddress = signup.EmailAddress;
                    signupVMs.Add(signupVM);
                }

                return View(signupVMs);                                         //passing list to the view
            }
        }
        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index"); //accepts string data type as a parameter
        }

    }
}