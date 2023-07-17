using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodefirstProject.Controllers
{
    public class ErorPageController : Controller
    {
        
        public ActionResult Page404()
        {
            return View();
        }
    }
}