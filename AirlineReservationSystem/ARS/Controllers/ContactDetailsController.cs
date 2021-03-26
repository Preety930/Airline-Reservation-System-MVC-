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
    public class ContactDetailsController : Controller
    {
        private ARSEntities db = new ARSEntities();

        // GET: ContactDetails
        public ActionResult Index()
        {
            var contact_Details = db.Contact_Details.Include(c => c.State1);
            return View(contact_Details.ToList());
        }

        // GET: ContactDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact_Details contact_Details = db.Contact_Details.Find(id);
            if (contact_Details == null)
            {
                return HttpNotFound();
            }
            return View(contact_Details);
        }

        // GET: ContactDetails/Create
        public ActionResult Create()
        {
            ViewBag.State = new SelectList(db.States, "StID", "StateName");
            return View();
        }

        // POST: ContactDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CnID,Email,Cell,Tel,Street,State")] Contact_Details contact_Details)
        {
            if (ModelState.IsValid)
            {
                db.Contact_Details.Add(contact_Details);
                db.SaveChanges();
                ViewBag.Message = "Successfully Registered...!!!";
                ViewBag.color = "green";
                //return RedirectToAction("Index");
            }

            ViewBag.State = new SelectList(db.States, "StID", "StateName", contact_Details.State);
            return View(contact_Details);
        }

        // GET: ContactDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact_Details contact_Details = db.Contact_Details.Find(id);
            if (contact_Details == null)
            {
                return HttpNotFound();
            }
            ViewBag.State = new SelectList(db.States, "StID", "StateName", contact_Details.State);
            return View(contact_Details);
        }

        // POST: ContactDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CnID,Email,Cell,Tel,Street,State")] Contact_Details contact_Details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact_Details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.State = new SelectList(db.States, "StID", "StateName", contact_Details.State);
            return View(contact_Details);
        }

        // GET: ContactDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact_Details contact_Details = db.Contact_Details.Find(id);
            if (contact_Details == null)
            {
                return HttpNotFound();
            }
            return View(contact_Details);
        }

        // POST: ContactDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact_Details contact_Details = db.Contact_Details.Find(id);
            db.Contact_Details.Remove(contact_Details);
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
