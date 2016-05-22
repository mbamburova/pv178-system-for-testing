using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL.Facades;
using BL.Repositories;
using WEB.Models;

namespace WEB.Controllers
{
    public class TestPrefaceController : Controller {

        private readonly TestPrefaceFacade testPrefaceFacade;

        public TestPrefaceController(TestPrefaceFacade testPrefaceFacade) {
            this.testPrefaceFacade = testPrefaceFacade;
        }

        public ActionResult TestPrefaces() {
            var testPrefaceViewModel = new TestPrefaceViewModel() {
                TestPrefaces = testPrefaceFacade.GetAllTestPrefaces()
            };
            return View("View", testPrefaceViewModel);
        }

        // GET: TestPreface
        public ActionResult Index()
        {
            return View();
        }

        // GET: TestPreface/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestPreface/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestPreface/Create
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

        // GET: TestPreface/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestPreface/Edit/5
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

        // GET: TestPreface/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestPreface/Delete/5
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
