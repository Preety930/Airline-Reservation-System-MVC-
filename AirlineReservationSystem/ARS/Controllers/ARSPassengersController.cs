using ARSDAL;
using ARSREPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARS.Controllers
{
    public class ARSPassengersController : Controller
    {
        IPassengers pass;
        // GET: ARSPassengers

        public ARSPassengersController(IPassengers pass)
        {
            this.pass = pass;
        }
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                return RedirectToAction("search","ARSSearch");
            }
            else
            {
                return View();
            }
            
        }
        [HttpPost]
        public ActionResult Index(Passenger model)
        {
            Passenger p = pass.ValidatePassenger(model.Name, model.Password);

            if(p==null)
            {
                ViewBag.Message = "Invalid Name and Password";
                return View(model);
            }
            else
            {
                Session["UserID"] = model.Name;
                    
                 
               
                return RedirectToAction("search","ARSSearch");
            }
           
        }
        public ActionResult AfterLogin()
        {
            Session["UserID"] = null;
            return RedirectToAction("Index", "HomePage");
        }
    }
}