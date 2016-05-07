using System.ComponentModel.DataAnnotations;

namespace BL.DTOs {
    public class TestPrefaceDTO {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int TimeInMinutes { get; set; }

        public virtual StudentGroupDTO StudentGroups { get; set; }

       // public virtual List<ThematicFieldDTO> ThematicFields { get; set; }

        public virtual TeacherDTO Teacher { get; set; }

        public int NumberOfQuestions { get; set; }

      /*  public TestPrefaceDTO() {
            ThematicFields = new List<ThematicFieldDTO>();
        }*/

        public override string ToString() {
            return $"TestPrefaceDTO: {Name}";
        }
    }
}
