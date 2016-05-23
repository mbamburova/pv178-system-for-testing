using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL.Facades;
using WEB.Models;

namespace WEB.Controllers
{
    public class ThematicFieldController : Controller
    {
        private readonly ThematicFieldFacade thematicFieldFacade;


        public ThematicFieldController(ThematicFieldFacade thematicFieldFacade) {
            this.thematicFieldFacade = thematicFieldFacade;
        }

        public ActionResult ThematicFields() {
            var thematicFieldViewModel = new ThematicFieldViewModel() {
                ThematicFields = thematicFieldFacade.GetAllThematicFields()
            };
            return View("View", thematicFieldViewModel);
        }

        // GET: ThematicField
        public ActionResult Index()
        {
            return View();
        }

        // GET: ThematicField/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ThematicField/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}
