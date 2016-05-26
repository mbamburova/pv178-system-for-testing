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
    public class StudentController : Controller {

        private readonly StudentFacade studentFacade;
        private readonly StudentGroupFacade studentGroupFacade;

        public StudentController(StudentFacade studentFacade) {
            this.studentFacade = studentFacade;
        }


        // GET: Student
        public ActionResult Index(int id) {
            return View("View", CreateStudentViewModel(id));
        }

        // GET: Student/Create
        public ActionResult Create(int groupId)
        {
            var studentEditViewModel = new StudentEditViewModel() {
                Student = new StudentDTO(),
                StudentGroup = studentGroupFacade.GetStudentGroupById(groupId)
            };
            return View(studentEditViewModel);
        }
        
        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentEditViewModel model) {
            studentFacade.CreateStudent(model.Student, model.StudentGroup.Id);
            return RedirectToAction("Index");
        }

        // GET: Student/Delete
        public ActionResult Delete(int id) {
            var studentGroup = studentFacade.GetStudentById(id).StudentGroup;
                 var studentGroupId = studentGroup.Id;
            studentFacade.DeleteStudent(id);
            return View("View", CreateStudentViewModel(studentGroupId));
        }

        private StudentViewModel CreateStudentViewModel(int id) {
            return new StudentViewModel() {
                Students = studentFacade.GetStudentsByStudentGroup(id),
                StudentGroupId = id,
            };
        }
    }
}
