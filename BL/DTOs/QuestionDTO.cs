using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BL.DTOs {
    public class QuestionDTO {
        public int Id { get; set; }

       // public List<AnswerDTO> Answers { get; set; }

        [Required]
        public string Text { get; set; }
        
        public int Points { get; set; }

        //public ThematicFieldDTO ThematicField { get; set; }

        [MaxLength(200)]
        public string Note { get; set; }

       /* public QuestionDTO() {
            Answers = new List<AnswerDTO>();
        }*/

        public override string ToString() {
            return $"QuestionDTO with ID: {Id}";
        }
    }
}
