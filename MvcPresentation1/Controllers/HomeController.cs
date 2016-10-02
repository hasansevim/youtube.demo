using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPresentation1.Controllers
{
    public class HomeController : Controller
    {
        // Global field
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
