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
    public class AdminGuideController : Controller
    {
        TravelContext travelcontext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelcontext.Guides.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddGuide(Guide guide)
        {
            travelcontext.Guides.Add(guide);
            travelcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteGuide(int id)
        {
            var value = travelcontext.Guides.Find(id);
            travelcontext.Guides.Remove(value);
            travelcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateGuide(int id)
        {
            var value = travelcontext.Guides.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateGuide(Guide guide)
        {
            var value = travelcontext.Guides.Find(guide.GuideID);
            value.GuideName = guide.GuideName;
            value.GuideTitle = guide.GuideTitle;
            value.GuideImageUrl = guide.GuideImageUrl;
            travelcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}