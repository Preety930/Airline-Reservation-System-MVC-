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
    public class SearchFlightNewController : Controller
    {
        private ARSEntities db = new ARSEntities();

        // GET: SearchFlightNew
        public ActionResult Index()
        {
            var result = db.SearchFlightNew("Kathmandu", "Pokhara");
            return View(result);

        }
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    SearchFlightNew_Result searchFlightNew_Result = db.SearchFlightNew_Result.Find(id);
        //    if (searchFlightNew_Result == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(searchFlightNew_Result);
        //    // return View();
        //}

        // GET: SearchFlightNew/Details/5
        //    public ActionResult Details(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        SearchFlightNew_Result searchFlightNew_Result = db.SearchFlightNew_Result.Find(id);
        //        if (searchFlightNew_Result == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(searchFlightNew_Result);
        //    }

        //    // GET: SearchFlightNew/Create
        //    public ActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: SearchFlightNew/Create
        //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Create([Bind(Include = "FlID,AcNumber,Airport,Destination,Capacity,Departure,Arrival,Fare")] SearchFlightNew_Result searchFlightNew_Result)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.SearchFlightNew_Result.Add(searchFlightNew_Result);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }

        //        return View(searchFlightNew_Result);
        //    }

        //    // GET: SearchFlightNew/Edit/5
        //    public ActionResult Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        SearchFlightNew_Result searchFlightNew_Result = db.SearchFlightNew_Result.Find(id);
        //        if (searchFlightNew_Result == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(searchFlightNew_Result);
        //    }

        //    // POST: SearchFlightNew/Edit/5
        //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit([Bind(Include = "FlID,AcNumber,Airport,Destination,Capacity,Departure,Arrival,Fare")] SearchFlightNew_Result searchFlightNew_Result)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.Entry(searchFlightNew_Result).State = EntityState.Modified;
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //        return View(searchFlightNew_Result);
        //    }

        //    // GET: SearchFlightNew/Delete/5
        //    public ActionResult Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }
        //        SearchFlightNew_Result searchFlightNew_Result = db.SearchFlightNew_Result.Find(id);
        //        if (searchFlightNew_Result == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(searchFlightNew_Result);
        //    }

        //    // POST: SearchFlightNew/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult DeleteConfirmed(int id)
        //    {
        //        SearchFlightNew_Result searchFlightNew_Result = db.SearchFlightNew_Result.Find(id);
        //        db.SearchFlightNew_Result.Remove(searchFlightNew_Result);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }
    }
}

