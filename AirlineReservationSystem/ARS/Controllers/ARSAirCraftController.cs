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
    public class ARSAirCraftController : Controller
    {
        private ARSEntities db = new ARSEntities();

        // GET: ARSAirCraft
        public ActionResult Index()
        {
            return View(db.AirCrafts.ToList());
        }

        // GET: ARSAirCraft/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirCraft airCraft = db.AirCrafts.Find(id);
            if (airCraft == null)
            {
                return HttpNotFound();
            }
            return View(airCraft);
        }

        // GET: ARSAirCraft/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ARSAirCraft/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AcID,AcNumber,Capacity,MfdBy,MfdOn")] AirCraft airCraft)
        {
            if (ModelState.IsValid)
            {
                db.AirCrafts.Add(airCraft);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(airCraft);
        }

        // GET: ARSAirCraft/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirCraft airCraft = db.AirCrafts.Find(id);
            if (airCraft == null)
            {
                return HttpNotFound();
            }
            return View(airCraft);
        }

        // POST: ARSAirCraft/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AcID,AcNumber,Capacity,MfdBy,MfdOn")] AirCraft airCraft)
        {
            if (ModelState.IsValid)
            {
                db.Entry(airCraft).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(airCraft);
        }

        // GET: ARSAirCraft/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirCraft airCraft = db.AirCrafts.Find(id);
            if (airCraft == null)
            {
                return HttpNotFound();
            }
            return View(airCraft);
        }

        // POST: ARSAirCraft/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AirCraft airCraft = db.AirCrafts.Find(id);
            db.AirCrafts.Remove(airCraft);
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
