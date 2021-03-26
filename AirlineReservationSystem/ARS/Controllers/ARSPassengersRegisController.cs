using ARSDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARS.Controllers
{
    public class ARSPassengersRegisController : Controller
    {
        private ARSEntities db = new ARSEntities();

        // GET: Passengers
        public ActionResult Index()
        {
            return View();
        }

        // GET: Passengers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Passengers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Passengers/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "PsID,Name,Address,Age,Nationality,Contacts,Password")] Passenger passenger)
        {
            try
            {
                if(ModelState.IsValid)

                db.Passengers.Add(passenger);
                db.SaveChanges();

                // TODO: Add insert logic here

                return RedirectToAction("Create","ContactDetails");
            }
            catch
            {
                return View();
            }
        }

        // GET: Passengers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Passengers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Passengers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Passengers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Regis()
        {
            return View();
        }
    }
}
