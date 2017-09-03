using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GolpoPuri.Areas.Users.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users/Users
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}