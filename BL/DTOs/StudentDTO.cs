using System.ComponentModel.DataAnnotations;

namespace BL.DTOs {
    public class StudentDTO {
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Surname { get; set; }

        public StudentGroupDTO StudentGroup { get; set; }

        public override string ToString() => $"StudentDTO {Name} {Surname}, with id: {Id}";
    }
}

