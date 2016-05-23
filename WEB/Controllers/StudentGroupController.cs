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
    public class StudentGroupController : Controller {

        private readonly StudentGroupFacade studentGroupFacade;

        public StudentGroupController(StudentGroupFacade studentGroupFacade) {
            this.studentGroupFacade = studentGroupFacade;
        }

        public ActionResult StudentGroups() {
            var studentGroupViewModel = new StudentGroupViewModel() {
                StudentGroups = studentGroupFacade.GetAllStudentGroups()
            };
            return View("StudentGroups", studentGroupViewModel);
        }
    }
}
