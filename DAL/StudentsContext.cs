using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public StudentsContext() : base() {
          //  Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsContext,Migrations.Configuration>());
          //????
          Database.SetInitializer(new DataInitializer());
        }
    }
}
