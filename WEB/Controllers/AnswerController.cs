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
        private readonly QuestionFacade questionFacade;


        public AnswerController(AnswerFacade answerFacade) {
            this.answerFacade = answerFacade;
        }

        // GET: Answer
        public ActionResult Index(int id)
        {
            return View("View", CreateAnswerViewModel(id));
        }

        private AnswerViewModel CreateAnswerViewModel(int id) {
            return new AnswerViewModel() {
                Answers = answerFacade.GetAnswersByQuestion(id),
                QuestionId = id
            };
        }

        // GET: Answer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: Answer/Delete/5
        public ActionResult Delete(int id) {

            // Question.Id
            var questionId = answerFacade.GetAswerById(id).Id;
            answerFacade.DeleteAnswer(id);
            return View("View", CreateAnswerViewModel(questionId));
        }

        public ActionResult Create() {
            var answerEditViewModel = new AnswerEditViewModel() {
                Answer = new AnswerDTO(),
               // Question = questionFacade.GetQuestionById()
            };

            return View("Create");
        }
    }
}
