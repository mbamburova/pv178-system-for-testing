using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities {
    public class TestPreface : IEntity<int> {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int TimeInMinutes { get; set; }

        public virtual StudentGroup StudentGroups { get; set; }

        public virtual List<ThematicField> ThematicFields { get; set; }

        public int NumberOfQuestions { get; set; }

        public virtual Teacher Teacher { get; set; }

        public TestPreface() {
            ThematicFields = new List<ThematicField>();
        }

        public override string ToString() {
            return $"TestPreface: {Name}";
        }
    }
}
