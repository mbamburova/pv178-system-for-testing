using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL.Facades;
using WEB.Models;

namespace WEB.Controllers
{
    public class QuestionController : Controller {
        private readonly QuestionFacade questionFacade;

        public QuestionController(QuestionFacade questionFacade) {
            this.questionFacade = questionFacade;
        }

        // GET: Question
        public ActionResult Index(int id) {
            return View("View", CreateQuestionViewModel(id));
        }

        private QuestionViewModel CreateQuestionViewModel(int id = 0) {
            return new QuestionViewModel() {
                Questions = questionFacade.GetQuestionsByThematicField(id),
                ThematicFieldId = id
            };
        }

        // GET: Question/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Question/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Question/Create
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

        // GET: Question/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Question/Edit/5
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

        // GET: Question/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Question/Delete/5
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
