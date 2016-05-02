using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities {
    public class Teacher : IEntity<int> {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<ThematicField> ThematicFields { get; set; }

        public virtual List<TestPreface> TestPrefaces { get; set; }

        public virtual List<StudentGroup> StudentGroups { get; set; }

        public Teacher() {
            ThematicFields = new List<ThematicField>();
            TestPrefaces = new List<TestPreface>();
            StudentGroups = new List<StudentGroup>();
        }

        public override string ToString() {
            return $"Teacher: {Name}";
        }
    }
}
