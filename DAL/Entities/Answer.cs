

using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities {
    public class Answer : IEntity<int> {

        public int Id { get; set; }

        public Question Question { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public override string ToString() {
            return Text;
        }
    }
}
