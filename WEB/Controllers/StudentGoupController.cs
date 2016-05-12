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
    public class StudentGoupController : Controller {

        private readonly StudentGroupFacade studentGroupFacade;


        public StudentGoupController(StudentGroupFacade studentGroupFacade) {
            this.studentGroupFacade = studentGroupFacade;
        }

        public ActionResult StudentGroups() {
            var studentGroupViewModel = new StudentGroupViewModel() {
                StudentGroups = studentGroupFacade.GetAllStudentGroups()
            };
            return View("StudentGroups", studentGroupViewModel);
        }
        /*
        // GET: StudentGoup
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentGoup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentGoup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentGoup/Create
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

        // GET: StudentGoup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentGoup/Edit/5
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

        // GET: StudentGoup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentGoup/Delete/5
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
            }*/
        }
}
