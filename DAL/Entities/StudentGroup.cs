using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities {
    public class StudentGroup {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Student> Students { get; set; }

        public virtual Teacher Teacher { get; set; }

        public StudentGroup() {
            Students = new List<Student>();
        }

        public override string ToString() {
            return Name;
        }
    }
}
