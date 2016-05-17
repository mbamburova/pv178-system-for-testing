﻿using System;
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

        private StudentViewModel CreateStudentViewModel(int id) {
            return new StudentViewModel() {
                Students = studentFacade.GetStudentsByStudentGroup(id),
                StudentGroupId = id,
            };
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create(int id)
        {
            return View("Create", CreateStudentEditViewModel());
        }

        private StudentEditViewModel CreateStudentEditViewModel(StudentDTO student = null) {
            return new StudentEditViewModel() {
                Student = student,
               // AvailableStudentGroups = new SelectList(studentGroupFacade.GetAllStudentGroups(), "Id", "Name"),
                StudentGroupId = student?.StudentGroup.Id ?? 0
            };
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentEditViewModel model)
        {
            studentFacade.CreateStudent(new StudentDTO(), model.StudentGroupId);
            return View("View", CreateStudentViewModel(model.StudentGroupId));
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
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

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
           // var studentsGroupId = studentFacade.GetStudentById(id).StudentGroup.Id;
            studentFacade.DeleteStudent(id);
            return View("View", CreateStudentViewModel(id));
        }

        // POST: Student/Delete/5
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
