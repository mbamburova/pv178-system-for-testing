using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BL.DTOs {
    public class ThematicFieldDTO {
        private TeacherDTO _teacher;
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<QuestionDTO> Questions { get; set; }

        public virtual TeacherDTO Teacher { get; set; }

        public ThematicFieldDTO Parent { get; set; }

        public virtual List<ThematicFieldDTO> Others { get; set; }

        public ThematicFieldDTO() {
            Questions = new List<QuestionDTO>();
            Others = new List<ThematicFieldDTO>();
        }

        public override string ToString() {
            return $"ThematicFieldDTO: {Name}";
        }
    }
}
