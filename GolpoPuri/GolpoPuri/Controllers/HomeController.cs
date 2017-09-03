using GolpoPuri.DAL;
using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GolpoPuri.Library;

namespace GolpoPuri.Controllers
{

    public class HomeController : Controller
    {
        //log4net variable declare
        private static readonly ILog log = LogManager.GetLogger("Test");



        IStoryModel _storyModel;
        public HomeController(IStoryModel _storyModel)
        {
            this._storyModel = _storyModel;
        }


        public ActionResult Index()
        {
            //successfully work log4net and we add later for database
            //log.Debug("test debug");


            //woerk successful
            _storyModel.CreateStory("this title", "this is body", "");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Developer()
        {
            return View();
        }
    }
}