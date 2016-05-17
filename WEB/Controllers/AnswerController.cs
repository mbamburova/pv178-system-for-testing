using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL.DTOs;
using BL.Facades;
using WEB.Models;

namespace WEB.Controllers
{
    public class AnswerController : Controller {
        private readonly AnswerFacade answerFacade;

        public AnswerController(AnswerFacade answerFacade) {
            this.answerFacade = answerFacade;
        }



        // GET: Answer
        public ActionResult Index(int id)
        {
            return View("View", CreateAnswerViewModel(id));
        }

        private AnswerViewModel CreateAnswerViewModel(int id) {
           /* var answers = answerFacade.GetAnswersByQuestion(id);
            var correct = new List<AnswerDTO>();
            for (int i = 0; i < answers.Count; i++) {
                if (answers[i].IsCorrect) {
                    correct.Add(answers[i]);
                }
            }*/
            return new AnswerViewModel() {
                Answers = answerFacade.GetAnswersByQuestion(id),
                QuestionId = id
            };
        }

        // GET: Answer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Answer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Answer/Create
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

        // GET: Answer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Answer/Edit/5
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

        // GET: Answer/Delete/5
        public ActionResult Delete(int id) {
            answerFacade.DeleteAnswer(id);
            return View("View", CreateAnswerViewModel(id));
        }

        // POST: Answer/Delete/5
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
