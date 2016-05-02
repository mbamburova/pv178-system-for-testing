using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs {
    class AnswerDTO {

        public int Id { get; set; }

        public QuestionDTO Question { get; set; }

        public string Text { get; set; }

        public override string ToString() {
            return Text;
        }
    }
}
