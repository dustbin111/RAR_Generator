using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RARGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The Risk Assessment Report Generator.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Just Don't.";

            return View();
        }
        
        // GET: RARGenerator/WarningBanner
        public ActionResult WarningBanner()
        {
            return View();
        }
    }
}