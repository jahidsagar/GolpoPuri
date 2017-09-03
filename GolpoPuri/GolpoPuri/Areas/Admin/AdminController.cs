using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GolpoPuri.Areas.Admin
{
    //[Authorize(Roles ="Admin",Users ="jahidsagar@gmail.com")]
    
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Golpo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Category()
        {
            return View("Index");
        }
    }
}