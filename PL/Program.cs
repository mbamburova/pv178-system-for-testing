using System;
using BL;
using BL.DTOs;
using BL.Facades;
using Castle.Windsor;

namespace PL {
    class Program {

        private static IWindsorContainer container;

        static void Main(string[] args) {

            PerformStartup();
            TestStudentFacade();
            TestAnswerFacade();
            TestQuestionFacade();
            TestStudentGroupFacade();
            TestPrefaceFacade();
            TestThematicFielFacade();
        }

        private static void TestStudentFacade() {
            var studentFacade = container.Resolve<StudentFacade>();
            
            var allStudents = studentFacade.GetAllStudents();
            var studentWithId58 = studentFacade.GetStudentById(58);
            var studentsWithStudentGroupId39 = studentFacade.GetStudentsByStudentGroup(39);

            //create student
            Console.WriteLine("New student");
            var studentName = Console.ReadLine();
            studentFacade.CreateStudent(new StudentDTO() {Name = studentName}, 40);

            //update student
            var studentWithId57 = studentFacade.GetStudentById(57);
            studentWithId57.Name = "Jana(Jano)";
            studentFacade.UpdateStudent(studentWithId57, 39);
        }

        private static void TestAnswerFacade() {
            var answerFacade = container.Resolve<AnswerFacade>();

            var allAnswers = answerFacade.GetAllAnswers();
            var answerWithId12 = answerFacade.GetAswerById(12);
            var allAnswersByQuestionWithId6 = answerFacade.GetAnswersByQuestion(6);
        }

        private static void TestQuestionFacade() {
            var questionFacade = container.Resolve<QuestionFacade>();

            var questionWithId7 = questionFacade.GetQuestionById(7);

            var questionsByThematicFieldWithId6 = questionFacade.GetQuestionsByThematicField(6);

            //nefunguje:(
            var allQuestions = questionFacade.GetAllQuestions();            
        }

        private static void TestStudentGroupFacade() {
            var studentGroupFacade = container.Resolve<StudentGroupFacade>();

            var allStudentsGroups = studentGroupFacade.GetAllStudentGroups();

            var studentGroupWithId40 = studentGroupFacade.GetStudentGroupById(40);
        
          /* not implemented
          studentGroupWithId40.Name = "skupina pro update";
          studentGroupFacade.UpdateStudentGroup(studentGroupWithId40, null);
          var updatedStudentGroup = studentGroupFacade.UpdateStudentGroup();
          */
        }

        private static void TestPrefaceFacade() {
            var testPrefaceFacade = container.Resolve<TestPrefaceFacade>();

            var allTestPrefaces = testPrefaceFacade.GetAllTestPrefaces();
            var testPrefaceWithWithId6 = testPrefaceFacade.GetTestPrefaceById(6);
        }

        private static void TestThematicFielFacade() {
            var thematicFieldFacade = container.Resolve<ThematicFieldFacade>();

            var allThematicFields = thematicFieldFacade.GetAllThematicFields();
            var thematicFieldWithId5 = thematicFieldFacade.GetThematicFieldById(5);
        }

        private static void PerformStartup() {
            container = new WindsorContainer();
            container.Install(new Installer());
        }
    }
}
