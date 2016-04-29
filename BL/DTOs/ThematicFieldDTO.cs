using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs {
    class ThematicFieldDTO {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<QuestionDTO> Questions { get; set; }

        public virtual TeacherDTO Teacher { get; set; }

        public ThematicFieldDTO() {
            Questions = new List<QuestionDTO>();
        }

        public override string ToString() {
            return $"ThematicFieldDTO: {Name}";
        }
    }
}
