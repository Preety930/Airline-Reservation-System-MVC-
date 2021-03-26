using ARS.Models;
using ARSDAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ARSREPO;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;

namespace ARS.Controllers
{
    public class ARSSearchController : Controller
    {

        IRoute route;
        ARSEntities db = new ARSEntities();
        public ARSSearchController(IRoute obj)
        {
            this.route = obj;
        }

        // GET: ARSSearch
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult search()
        {
            if (Session["UserID"] != null)
            {
                ViewBag.dcity = db.Routes.Select(l => l.Airport).Distinct().ToList();
                ViewBag.acity = db.Routes.Select(l => l.Destination).Distinct().ToList();
                // Session["From"] = model.From;
                //Session["To"] = model.To;

                return View();
            }
            else
            {
                return RedirectToAction("Index","ARSPassengers");
            }
        }
        
        [HttpPost]
        public ActionResult fsearch(FromTo model)
        {
            //    Route ad = route.ValidateRoute(model.From, model.To);
            //    Session["from"] = model.From;
            //    Session["to"] = model.To;
            ARSEntities db = new ARSEntities();
            List<ARSDAL.AirCraft> airCrafts = db.AirCrafts.ToList();
            List<Flight_Schedule> flight_Schedules = db.Flight_Schedule.ToList();
            List<AirFare> airFares = db.AirFares.ToList();
            List<Route> routes = db.Routes.ToList();



            var r1 = from e in airCrafts
                     join d in flight_Schedules on e.AcID equals d.AirCraft
                     join i in airFares on d.NetFare equals i.AfID
                     join j in routes on i.Route equals j.RtID
                     where
                     j.Airport == model.From &&
                j.Destination == model.To
                     select new SearchTicket
                     {
                         aircrafts = e,
                         Flight = d,
                         airFares = i,
                         routes = j
                     };

           
           
            return View(r1);


        

            


        }
        public ActionResult Create()
        {
            return View();
        }


        [HandleError(View = "ErrorPage")]
        [HttpPost]
        public ActionResult Create([Bind(Include = "PsID,PAssengername, Age,AcNumber,Departure,Arrival,Airport,Destination,Fare")] Booking book)
        {
            Session["p"] = book.PsID;
            //Session["d"] = book.Departure;
            //Session["pn"] = book.PAssengerName;
            //Session["age"] = book.Age;
            //Session["Acno"] = book.AcNumber;
            //Session["arrival"] = book.Arrival;
            //Session["ap"] = book.Airport;
            //Session["f"] = book.Fare;

            if (ModelState.IsValid)
            {
                var name = Request["AcNumber"];
                db.DecrementCapacity(name);
                var c = db.AirCrafts.Where(x => x.AcNumber == name).Select(x => x.Capacity).FirstOrDefault();
                if (c > 0)
                {
                    db.Bookings.Add(book);
                    db.SaveChanges();
                    return RedirectToAction("Create");
                }
                else

                {
                    ViewBag.Message = "No Seats Available";
                    return View();

                }




            }
            return View(book);
        

        }
        [HandleError]
        [HttpPost]
        
        public ActionResult AmountToPay()
        {
            try
            {
                string a = Session["d"].ToString();
                
                //DateTime date1 = DateTime.ParseExact(a, "dd/MM/yyyy hh:mm:ss",null);
                DateTime date1 = Convert.ToDateTime(a);

                //DateTime date1 = DateTime.ParseExact(a, "yyyy-MM-dd hh:mm:ss", CultureInfo.InvariantCulture);
               SqlParameter sq = new SqlParameter("@Departure", SqlDbType.DateTime);
                sq.Value = date1;
                string b = Session["p"].ToString();
                int c = Convert.ToInt32(b);
                // int result = db.AmountToPay(date1, c);
                 //ViewBag.Message = result;
                return View();
            }
            catch(System.NullReferenceException e )
            {
                
                return View("ErrorPage");
            }
            catch (Exception e)
            {

                return View("ErrorPage");
            }

        }
        [HttpPost]
        public ActionResult ViewTicket()
        {
            string a = Session["d"].ToString();
            // DateTime date1 = DateTime.ParseExact(a, "dd/MM/yyyy hh:mm:ss",null);
            DateTime date1 = Convert.ToDateTime(a);
            string b = Session["p"].ToString();
            int c = Convert.ToInt32(b);
            var ticket = db.ViewTicket1(c, date1);
            return View();
        }

        public ActionResult Pay()
        {
            return View();
        }
        public ActionResult ViewTicket1()
        {

            return View(db.Bookings.ToList());
        }
   













    }
}
