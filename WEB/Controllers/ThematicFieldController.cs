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

        // POST: ThematicField/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ThematicField/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThematicField/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ThematicField/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ThematicField/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
