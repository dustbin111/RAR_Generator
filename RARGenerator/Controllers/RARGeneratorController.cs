using RARGenerator.Models;
using RARGenerator.Utilities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.Web.Mvc;

namespace RARGenerator.Controllers
{
    public class RARGeneratorController : Controller
    {
        // GET: RARGenerator
        public ActionResult Index()
        {
            return View();
        }

        // GET: RARGenerator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RARGenerator/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: RARGenerator/Facility
        public ActionResult Facility()
        {
            
            return View(GetViewModel().Facility);
        }

        // POST: RARGenerator/Facility
        [HttpPost]
        public ActionResult Facility(Facility facility, string direction)
        {
            SessionViewModel viewModel = GetViewModel();

            viewModel.Facility = facility;
            Session["RAR"] = viewModel;
            if (!string.IsNullOrEmpty(direction))
            {
                return RedirectToAction(direction);
            }

            return View(viewModel.Facility);
        }

        // GET: RARGenerator/WarningBanner
        public ActionResult WarningBanner()
        {
            // Creates local variable of viewModel
            SessionViewModel viewModel = GetViewModel();
            return View(viewModel.WarningBanner);
        }

        // POST: RARGenerator/WarningBanner
        [HttpPost]
        public ActionResult WarningBanner(WarningBanner warningBanner)
        {
            SessionViewModel viewModel = GetViewModel();

            viewModel.WarningBanner = warningBanner;
            Session["RAR"] = viewModel;

            return RedirectToAction("NewOrUpload");
        }

        // GET: RARGenerator/RARScope
        public ActionResult RARScope()
        {
            return View();
        }

        // GET: RARGenerator/Threats
        public ActionResult Threats()
        {
            return View();
        }

        // GET: RARGenerator/System
        public ActionResult System()
        {
            return View();
        }

        // GET: RARGenerator/NewOrUpload
        public ActionResult NewOrUpload()
        {
            return View();
        }

        // GET: RARGenerator/ReviewAnalysis
        public ActionResult ReviewAnalysis()
        {
            return View();
        }

        // GET: RARGenerator/GenerateRAR
        [WordDocument(DefaultFilename = "SOME_STATIC_STRING")]
        public ActionResult GenerateRAR()
        {
            var viewModel = GetViewModel();

            ViewBag.WordDocumentFilename = viewModel.Facility.FacilityCAGE;

            return View(viewModel);
        }

        // GET: RARGenerator/PreviewRAR
        public ActionResult PreviewRAR()
        {
            var viewModel = GetViewModel();

            return View("GenerateRAR", "_RARGeneratorLayout", viewModel);
        }

        // GET: RARGenerator/RARNavigation
        public ActionResult RARNavigation()
        {
            return View();
        }

        // POST: RARGenerator/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RARGenerator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RARGenerator/Edit/5
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

        // GET: RARGenerator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RARGenerator/Delete/5
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

        public SessionViewModel GetViewModel()
        {
            var viewModel = new SessionViewModel();
            
            // Check and see if something is in memory
            if (Session["RAR"] != null)
            {
                viewModel = (SessionViewModel)Session["RAR"];
            }

            return viewModel;
        }
    }
}
