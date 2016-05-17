using System.Data.Entity;
using DAL.Entities;

namespace DAL {
    public class StudentsContext : DbContext {

        public DbSet<Student> Students { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TestPreface> TestPrefaces { get; set; }
        public DbSet<ThematicField> ThematicFields { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public StudentsContext() : base("Bamburova-MB") {
         //  Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsContext,Migrations.Configuration>());
        
         //  Database.SetInitializer(new DataInitializer());
        }
    }
}
