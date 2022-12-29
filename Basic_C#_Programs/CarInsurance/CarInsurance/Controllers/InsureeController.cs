using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;



namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuraceEntities db = new InsuraceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree = QuoteLogic(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //GET ADMIN
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        public Insuree QuoteLogic(Insuree insuree)
        {
            insuree.Quote = 50;
            if ((DateTime.Now.Year - insuree.DateOfBirth.Year) <= 18)
            {
                insuree.Quote = insuree.Quote + 100;
            }
            if ((DateTime.Now.Year - insuree.DateOfBirth.Year) >= 19 && (DateTime.Now.Year - insuree.DateOfBirth.Year) <= 25)
            {
                insuree.Quote = insuree.Quote + 50;
            }
            if ((DateTime.Now.Year - insuree.DateOfBirth.Year) > 25)
            {
                insuree.Quote = insuree.Quote + 25;
            }
            if (insuree.CarYear < 2000)
            {
                insuree.Quote = insuree.Quote + 25;
            }
            if (insuree.CarYear > 2015)
            {
                insuree.Quote = insuree.Quote + 25;
            }
            if (insuree.CarMake == "Porsche")
            {
                insuree.Quote = insuree.Quote + 25;
            }
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                insuree.Quote = insuree.Quote + 25;
            }
            if (insuree.SpeedingTickets >= 1)
            {
                insuree.Quote = insuree.Quote + (10 * insuree.SpeedingTickets);
            }
            if (insuree.DUI == true)
            {
                insuree.Quote = insuree.Quote + (insuree.Quote * .25m);
            }
            if (insuree.CoverageType == true)
            {
                insuree.Quote = insuree.Quote + (insuree.Quote * .50m);
            }
            return insuree;

        }
    }

}
