using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs {
    class QuestionDTO {
        public int Id { get; set; }

        public int NumberOfCorrectAnswers { get; set; }

        public string Text { get; set; }

        public string Answer { get; set; }

        public int Points { get; set; }

        public ThematicFieldDTO ThematicField { get; set; }

        [MaxLength(200)]
        public string Note { get; set; }

        public override string ToString() {
            return $"Question with ID: {Id}";
        }
    }
}
