using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BL.DTOs {
    class QuestionDTO {
        public int Id { get; set; }

        public List<AnswerDTO> Answers { get; set; }

        public string Text { get; set; }

        public string Answer { get; set; }

        public int Points { get; set; }

        public ThematicFieldDTO ThematicField { get; set; }

        [MaxLength(200)]
        public string Note { get; set; }

        public QuestionDTO() {
            Answers = new List<AnswerDTO>();
        }

        public override string ToString() {
            return $"Question with ID: {Id}";
        }
    }
}
