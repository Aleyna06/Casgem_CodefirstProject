using Casgem_CodefirstProject.DAL.Context;
using Casgem_CodefirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodefirstProject.Controllers
{
    [Authorize]
    public class AdminAboutController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Abouts.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AdminAboutUpdate(int id)
        {
            var values = travelContext.Abouts.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult AdminAboutUpdate(About p)
        {
            var values = travelContext.Abouts.Find(p.AboutID);
            values.Title = p.Title;
            values.Description = p.Description;
            travelContext.SaveChanges();
            return View(values);
        }

    }

}