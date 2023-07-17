using Casgem_CodefirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodefirstProject.Controllers
{
    public class ExploreController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialService()
        {
            var values = travelContext.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialImage()
        {
            var values = travelContext.Galeries.ToList();
            return PartialView(values);
        }
    }
}