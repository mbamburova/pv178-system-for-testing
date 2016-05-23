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

        // GET: TestPreface/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
