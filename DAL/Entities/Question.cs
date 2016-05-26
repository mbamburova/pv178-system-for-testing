using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities {
    public class Question : IEntity<int> {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public virtual List<Answer> Answers { get; set; }

        public int Points { get; set; }

        public virtual ThematicField ThematicField { get; set; }

        [MaxLength(200)]
        public string Note { get; set; }

        public Question() {
            Answers = new List<Answer>();
        }

        public override string ToString() {
            return $"Question with ID: {Id}";
        }
    }
}
