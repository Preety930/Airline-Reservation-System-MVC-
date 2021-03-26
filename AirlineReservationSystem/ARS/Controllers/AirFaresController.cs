using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ARSDAL;

namespace ARS.Controllers
{
    public class AirFaresController : Controller
    {
        private ARSEntities db = new ARSEntities();

        // GET: AirFares
        public ActionResult Index()
        {
            var airFares = db.AirFares.Include(a => a.Route1);
            return View(airFares.ToList());
        }

        // GET: AirFares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirFare airFare = db.AirFares.Find(id);
            if (airFare == null)
            {
                return HttpNotFound();
            }
            return View(airFare);
        }

        // GET: AirFares/Create
        public ActionResult Create()
        {
            ViewBag.Route = new SelectList(db.Routes, "RtID", "Airport");
            return View();
        }

        // POST: AirFares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AfID,Route,Fare,FSC")] AirFare airFare)
        {
            if (ModelState.IsValid)
            {
                db.AirFares.Add(airFare);
                db.SaveChanges();
                return RedirectToAction("Create","Flight_Schedule");
            }

            ViewBag.Route = new SelectList(db.Routes, "RtID", "Airport", airFare.Route);
            return View(airFare);
        }

        // GET: AirFares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirFare airFare = db.AirFares.Find(id);
            if (airFare == null)
            {
                return HttpNotFound();
            }
            ViewBag.Route = new SelectList(db.Routes, "RtID", "Airport", airFare.Route);
            return View(airFare);
        }

        // POST: AirFares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AfID,Route,Fare,FSC")] AirFare airFare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(airFare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Route = new SelectList(db.Routes, "RtID", "Airport", airFare.Route);
            return View(airFare);
        }

        // GET: AirFares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirFare airFare = db.AirFares.Find(id);
            if (airFare == null)
            {
                return HttpNotFound();
            }
            return View(airFare);
        }

        // POST: AirFares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AirFare airFare = db.AirFares.Find(id);
            db.AirFares.Remove(airFare);
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
    }
}
