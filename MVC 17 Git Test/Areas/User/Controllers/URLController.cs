using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_17_Git_Test.Areas.User.Controllers
{
    public class URLController : Controller
    {
        // GET: User/URL
        public ActionResult Index()
        {
            LinkHubDbEntities db = new LinkHubDbEntities();
            ViewBag.CategoryID = new SelectList(db.tbl_Category, "CategoryId", "CategoryName");
            return View();
        }

        public ActionResult Create(tbl_Url objUrl)
        {
            //LinkHubDbEntities db = new LinkHubDbEntities();
            //ViewBag.CategoryID = new SelectList(db.tbl_Category, "CategoryId", "CategoryName");
            return View();
        }
    }
}