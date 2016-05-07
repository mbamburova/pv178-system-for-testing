

namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;


    internal sealed class Configuration : DbMigrationsConfiguration<DAL.StudentsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DAL.StudentsContext";
        }

        protected override void Seed(DAL.StudentsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            /* udaje sa ulozia do tabuliek
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

            var studentGroup1 = new StudentGroup() {
                Name = "skupina 1",
                Students = new List<Student>() { student1, student2, student3 }
            };

            var studentGroup2 = new StudentGroup() {
                Name = "skupina 2",
                Students = new List<Student>() { student4 }
            };

            context.Students.Add(student1);
            context.Students.Add(student2);
            context.Students.Add(student3);
            context.Students.Add(student4);

            context.StudentGroups.Add(studentGroup1);
            context.StudentGroups.Add(studentGroup2);

            context.SaveChanges();*/
        }
    }
}
