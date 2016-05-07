using System.ComponentModel.DataAnnotations;

namespace BL.DTOs {
    public class StudentGroupDTO {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

       // public virtual List<StudentDTO> Students { get; set; }

        public virtual TeacherDTO Teacher { get; set; }

       /* public StudentGroupDTO() {
            Students = new List<StudentDTO>();
        }*/

        public override string ToString() {
            return Name;
        }
    }
}
