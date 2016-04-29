using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities {
    public class TestPreface {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int TimeInMinutes { get; set; }

        public virtual StudentGroup StudentGroups { get; set; }

        public virtual List<ThematicField> ThematicFields { get; set; }

        public virtual Teacher Teacher { get; set; }

        public TestPreface() {
            ThematicFields = new List<ThematicField>();
        }

        public override string ToString() {
            return $"TestPreface: {Name}";
        }
    }
}
