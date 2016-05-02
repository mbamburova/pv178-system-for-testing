using System.ComponentModel.DataAnnotations;

namespace DAL.Entities {
    public class Student {
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
