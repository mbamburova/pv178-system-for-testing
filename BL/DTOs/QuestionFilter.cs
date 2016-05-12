using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs {
    public class QuestionFilter {
        public string QuestionText { get; set; }

        public int ThematicFieldId { get; set; }

        public int AnswerId { get; set; }

        public int QuestionId { get; set; }

    }
}
