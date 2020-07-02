using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_17_Git_Test.Areas.Common.Controllers
{
    public class HomeController : Controller
    {
        // GET: Common/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}