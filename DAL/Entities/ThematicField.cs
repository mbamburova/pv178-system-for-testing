using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities {
    public class ThematicField : IEntity<int> {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Question> Questions { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual ThematicField Parent { get; set; }

        public virtual List<ThematicField> Childrens { get; set; }

        public virtual TestPreface TestPreface { get; set; }

        public ThematicField() {
            Questions = new List<Question>();
            Childrens = new List<ThematicField>();
        }

        public override string ToString() {
            return $"Thematic field: {Name}";
        }
    }
}
