using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs {
    public class TeacherDTO {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<ThematicFieldDTO> ThematicFields { get; set; }

        public virtual List<TestPrefaceDTO> TestPrefaces { get; set; }

        public virtual List<StudentGroupDTO> StudentGroups { get; set; }

        public TeacherDTO() {
            ThematicFields = new List<ThematicFieldDTO>();
            TestPrefaces = new List<TestPrefaceDTO>();
            StudentGroups = new List<StudentGroupDTO>();
        }

        public override string ToString() {
            return $"TeacherDTO: {Name}";
        }
    }
}
