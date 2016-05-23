using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL.Facades;
using WEB.Models;

namespace WEB.Controllers
{
    public class HomeController : Controller {
        private readonly StudentGroupFacade studentGroupFacade;
        private readonly ThematicFieldFacade thematicFieldFacade;

        public HomeController(StudentGroupFacade studentGroupFacade, ThematicFieldFacade thematicFieldFacade) {
            this.studentGroupFacade = studentGroupFacade;
            this.thematicFieldFacade = thematicFieldFacade;
        }


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
