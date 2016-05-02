using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities {
    public class StudentGroup : IEntity<int> {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Student> Students { get; set; }

        public virtual Teacher Teacher { get; set; }

        public StudentGroup() {
            Students = new List<Student>();
        }

        public override string ToString() {
            return Name;
        }
    }
}
