using ARSDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARS.Controllers
{
    public class ARSPassengersInfoController : Controller
    {
        // GET: ARSPassengersInfo
        private ARSEntities db = new ARSEntities();
        // GET: PassengerInfo
        public ActionResult Index()
        {
            return View(db.Passengers.ToList());

        }
        public ActionResult Page1()
        {
            return View(db.Passengers.ToList());

        }
        public ActionResult Page2()
        {
            return View();
        }

    }
}