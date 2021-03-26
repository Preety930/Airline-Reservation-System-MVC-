using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ARSDAL;
using ARSREPO;

namespace ARS.Controllers
{
    public class ARSAdminController : Controller
    {
        IAdmin admin;
        // GET: ARSAdmin

        public ARSAdminController(IAdmin admin)
        {
            this.admin = admin;
        }
        [HttpGet]
        public ActionResult Index()
        {
            if (Session["u"] != null)
            {
                return RedirectToAction("Page2");
            }
            else
            {
                return View();
            }
            
            
        }

        [HttpPost]
        public ActionResult Index(Admin model)
        {
            Admin ad = admin.ValidateAdmin(model.Name, model.Password);

            if (ad==null)
            {
                
                ViewBag.Message = "Invalid Name or Password";
                ViewBag.color = "red";
                return View(model);
            }
            else
            {
                Session["u"] = model.Name;
                return RedirectToAction("Page2");
            }
        }
        public ActionResult Page2()
        {
            if (Session["u"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        public ActionResult LogOut()
        {
            Session["u"] = null;
            return RedirectToAction("Index");
        }
    }
}