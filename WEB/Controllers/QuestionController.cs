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

        // GET: Question/Delete/5
        public ActionResult Delete(int id)
        {
            questionFacade.DeleteQuestion(id);
            return View("View", CreateQuestionViewModel(id));
        }
    }
}
