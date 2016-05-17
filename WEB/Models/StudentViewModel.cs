using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BL.DTOs;

namespace WEB.Models {
    public class StudentViewModel {


        public List<StudentDTO> Students { get; set; } 

        public int StudentGroupId { get; set; }

        public StudentViewModel() {
            Students = new List<StudentDTO>();
        }
    }
}