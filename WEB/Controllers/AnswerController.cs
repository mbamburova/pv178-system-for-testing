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

        public ActionResult Delete(int id) {
            var questionId = answerFacade.GetAswerById(id).Question.Id;
            answerFacade.DeleteAnswer(id);

            return View("View", CreateAnswerViewModel(questionId));
        }
    }
}
