using System.ComponentModel.DataAnnotations;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities {
    public class Answer : IEntity<int> {

        public int Id { get; set; }

        [Required]
        public Question Question { get; set; }

        [Required]
        [MaxLength(255)]
        public string Text { get; set; }

        [Required]
        public bool IsCorrect { get; set; }

        public override string ToString() {
            return Text;
        }
    }
}
