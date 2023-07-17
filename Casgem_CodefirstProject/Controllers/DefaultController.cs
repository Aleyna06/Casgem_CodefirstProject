using Casgem_CodefirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodefirstProject.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext travelcontext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        public PartialViewResult PartialMainScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }
        public PartialViewResult PartialRezervesion()
        {
            return PartialView();
        }
        public PartialViewResult PartialTripCity()
        {
            return PartialView();
        }
        public PartialViewResult PartialDestination()
        {
            var values = travelcontext.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialBookDetails()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
    }
}