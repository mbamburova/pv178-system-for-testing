using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL {
    class DataInitializer : CreateDatabaseIfNotExists<StudentsContext> {

        protected override void Seed(StudentsContext context) {
            
            var student1 = new Student() {
                Name = "Jano",
                Surname = "Maly",
            };

            var student2 = new Student() {
                Name = "Fero",
                Surname = "Velky",
            };

            var student3 = new Student() {
                Name = "Eva",
                Surname = "Cierna"
            };

            var student4 = new Student() {
                Name = "Adam",
                Surname = "Biely"
            };

            var student5 = new Student() {
                Name = "Kaja",
                Surname = "Biela"
            };

            var studentGroup1 = new StudentGroup() {
                Name = "skupina 1",
                Students = new List<Student>() { student1, student2, student3 }
            };

            var studentGroup2 = new StudentGroup() {
                Name = "skupina 2",
                Students = new List<Student>() { student4}
            };

            context.Students.Add(student1);
            context.Students.Add(student2);
            context.Students.Add(student3);
            context.Students.Add(student4);

            // nie je v tabulke (?????)
            context.Students.Add(student5);

            context.StudentGroups.Add(studentGroup1);
            context.StudentGroups.Add(studentGroup2);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
