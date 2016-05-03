
namespace BL.DTOs {
    class AnswerDTO {

        public int Id { get; set; }

        public QuestionDTO Question { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public override string ToString() {
            return Text;
        }
    }
}
