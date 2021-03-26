using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARS.Controllers
{
    public class ViewTicketController : Controller
    {
        // GET: ViewTicket
        public ActionResult Index()
        {
            return View();
        }
    }
}