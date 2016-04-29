using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    class DataInitializer : DropCreateDatabaseAlways<StudentsContext> {

        protected override void Seed(StudentsContext context) {
            
        }
    }
}
