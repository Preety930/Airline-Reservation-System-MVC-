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
    public class SearchFlight_ResultController : Controller
    {
        private ARSEntities db = new ARSEntities();

        // GET: SearchFlight_Result
        public ActionResult Index()
        {
            //return View(db.SearchFlight_Result.ToList());
            var result = db.SearchFlightNew("Kathmandu", "Pokhara");
            return View(result);
        
        }

        // GET: SearchFlight_Result/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    SearchFlight_Result searchFlight_Result = db.SearchFlight_Result.Find(id);
        //    if (searchFlight_Result == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(searchFlight_Result);
        //}

        // GET: SearchFlight_Result/Create
    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: SearchFlight_Result/Create
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Create([Bind(Include = "AcNumber,Airport,Destination,Capacity,Departure,Arrival,Fare")] SearchFlight_Result searchFlight_Result)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.SearchFlight_Result.Add(searchFlight_Result);
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }

    //        return View(searchFlight_Result);
    //    }

    //    // GET: SearchFlight_Result/Edit/5
    //    public ActionResult Edit(string id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        SearchFlight_Result searchFlight_Result = db.SearchFlight_Result.Find(id);
    //        if (searchFlight_Result == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(searchFlight_Result);
    //    }

    //    // POST: SearchFlight_Result/Edit/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit([Bind(Include = "AcNumber,Airport,Destination,Capacity,Departure,Arrival,Fare")] SearchFlight_Result searchFlight_Result)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Entry(searchFlight_Result).State = EntityState.Modified;
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }
    //        return View(searchFlight_Result);
    //    }

    //    // GET: SearchFlight_Result/Delete/5
    //    public ActionResult Delete(string id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        SearchFlight_Result searchFlight_Result = db.SearchFlight_Result.Find(id);
    //        if (searchFlight_Result == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(searchFlight_Result);
    //    }

    //    // POST: SearchFlight_Result/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult DeleteConfirmed(string id)
    //    {
    //        SearchFlight_Result searchFlight_Result = db.SearchFlight_Result.Find(id);
    //        db.SearchFlight_Result.Remove(searchFlight_Result);
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
