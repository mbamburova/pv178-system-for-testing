

using System.Collections.Generic;
using DAL.Entities;

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

            // udaje sa ulozia do tabuliek


            var student1 = new Student() {
                Name = "Jano",
                Surname = "Maly"
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

            var answer1 = new Answer() {

                Text = "Ano",
                IsCorrect = true,
            };

            var answer2 = new Answer() {
                Text = "Nie",
                IsCorrect = false,
            };

            var question1 = new Question() {
                Answers = new List<Answer>() { answer1, answer2 },
                Text = "Delime siete podla funkcneho vztahu na Client-Server a Peer-to-Peer?",
                Points = 2,
            };

            answer1.Question = question1;
            answer2.Question = question1;
            
            var thematicField1 = new ThematicField() {
                Name = "okruh sieti",
                Questions = new List<Question>() { question1 },
                Childrens = new List<ThematicField>() { }
            };

            question1.ThematicField = thematicField1;

            var testPreface1 = new TestPreface() {
                Name = "Test Siete",
                TimeInMinutes = 60,
                ThematicFields = new List<ThematicField>() { thematicField1 },
                NumberOfQuestions = 1
            };
            thematicField1.TestPreface = testPreface1;


            var answer3 = new Answer() {

                Text = "Ano",
                IsCorrect = true,
            };

            var answer4 = new Answer() {
                Text = "Nie",
                IsCorrect = false,
            };

            var question2 = new Question() {
                Answers = new List<Answer>() { answer3, answer4 },
                Text = "Uci Brandejs UNIX?",
                Points = 2,
            };

            answer3.Question = question2;
            answer4.Question = question2;

            var thematicField2 = new ThematicField() {
                Name = "okruh unix",
                Questions = new List<Question>() { question2 },
                Childrens = new List<ThematicField>() { }
            };

            question2.ThematicField = thematicField2;

            var testPreface2 = new TestPreface() {
                Name = "Test unix",
                TimeInMinutes = 60,
                ThematicFields = new List<ThematicField>() { thematicField2 },
                NumberOfQuestions = 1
            };
            thematicField2.TestPreface = testPreface2;
           

            var studentGroup1 = new StudentGroup() {
                Name = "skupina 1",
                Students = new List<Student>() { student1, student2, student3 },
                TestPrefaces = new List<TestPreface>() { testPreface1}
            };

            var studentGroup2 = new StudentGroup() {
                Name = "skupina 2",
                Students = new List<Student>() { student4 },
                TestPrefaces = new List<TestPreface>() { testPreface2 }
            };

            student1.StudentGroup = studentGroup1;
            student2.StudentGroup = studentGroup1;
            student3.StudentGroup = studentGroup1;
            student4.StudentGroup = studentGroup2;
            
            var teacher = new Teacher() {
                Name = "ucitel z FI MUNI",
                StudentGroups = new List<StudentGroup>() { studentGroup1, studentGroup2 },
                TestPrefaces = new List<TestPreface>() {testPreface1, testPreface2 },
                ThematicFields = new List<ThematicField>() {thematicField1, thematicField2 }
            };


            context.Students.AddOrUpdate(student1);
            context.Students.AddOrUpdate(student2);
            context.Students.AddOrUpdate(student3);
            context.Students.AddOrUpdate(student4);

            context.StudentGroups.AddOrUpdate(studentGroup1);
            context.StudentGroups.AddOrUpdate(studentGroup2);

            context.Answers.AddOrUpdate(answer1);
            context.Answers.AddOrUpdate(answer2);
            context.Answers.AddOrUpdate(answer3);
            context.Answers.AddOrUpdate(answer4);

            context.Questions.AddOrUpdate(question1);
            context.Questions.AddOrUpdate(question2);

            context.Teachers.AddOrUpdate(teacher);

            context.TestPrefaces.AddOrUpdate(testPreface1);
            context.TestPrefaces.AddOrUpdate(testPreface2);

            context.ThematicFields.AddOrUpdate(thematicField1);
            context.ThematicFields.AddOrUpdate(thematicField2);

    
            context.SaveChanges();
        }
    }
}
