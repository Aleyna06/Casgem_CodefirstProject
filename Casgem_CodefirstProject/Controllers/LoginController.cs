using Casgem_CodefirstProject.DAL.Context;
using Casgem_CodefirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Casgem_CodefirstProject.Controllers
{
    public class LoginController : Controller
    {
        TravelContext travelcontext = new TravelContext();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = travelcontext.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password==admin.Password);

            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["usertravel"] = values.UserName.ToString();
                return RedirectToAction("Index", "AdminGuide");
            }
            else
            {
                return View();
            }

        }
    }
}