using System.Collections.Generic;

namespace DAL.Entities {
    public class ThematicField {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Question> Questions { get; set; }

        public virtual Teacher Teacher { get; set; }

        public ThematicField() {
            Questions = new List<Question>();
        }

        public override string ToString() {
            return $"Thematic field: {Name}";
        }
    }
}
