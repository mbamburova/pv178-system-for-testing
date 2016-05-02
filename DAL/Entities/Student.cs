using System.ComponentModel.DataAnnotations;
using Riganti.Utils.Infrastructure.Core;

namespace DAL.Entities {
    public class Student : IEntity<int> {
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Surname { get; set; }

        public StudentGroup StudentGroup { get; set; }

        public override string ToString() => $"Student {Name} {Surname}, with id: {Id}";
    }
}
