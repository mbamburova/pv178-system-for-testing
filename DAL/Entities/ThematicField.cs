using System.Collections.Generic;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities {
    public class ThematicField : IEntity<int> {
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
