
using System.ComponentModel.DataAnnotations;

namespace BL.DTOs {
    class AnswerDTO {

        public int Id { get; set; }

        public QuestionDTO Question { get; set; }

        [MaxLength(255)]
        public string Text { get; set; }

        [Required]
        public bool IsCorrect { get; set; }

        public override string ToString() {
            return Text;
        }
    }
}
