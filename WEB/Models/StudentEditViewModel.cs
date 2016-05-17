using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL.DTOs;

namespace WEB.Models {
    public class StudentEditViewModel {

        public StudentDTO Student { get; set; }

      //  public SelectList AvailableStudentGroups { get; set; }

        public int StudentGroupId { get; set; }
    }
}