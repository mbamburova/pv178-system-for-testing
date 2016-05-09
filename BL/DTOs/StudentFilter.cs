using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs {
    public class StudentFilter {

        public string StudentName { get; set; }

        public int StudentGroupId { get; set; }

        public int AnswerId { get; set; }

        public string QuestionText { get; set; }
    }
}
