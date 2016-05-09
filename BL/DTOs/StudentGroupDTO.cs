using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAL.Entities;

namespace BL.DTOs {
    public class StudentGroupDTO {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

       // public virtual List<StudentDTO> Students { get; set; }

        public virtual TeacherDTO Teacher { get; set; }

       // public virtual List<TestPrefaceDTO> TestPrefaces { get; set; }

        /* public StudentGroupDTO() {
             Students = new List<StudentDTO>();
             TestPrefaces = new List<TestPrefaces>();
         }*/

        public override string ToString() {
            return Name;
        }
    }
}
