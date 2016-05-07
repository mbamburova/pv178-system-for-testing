using BL;
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
            TestTeacherFacade();
            TestPrefaceFacade();
            TestThematicFielFacade();

        }

        private static void TestStudentFacade() {
            var studentFacade = container.Resolve<StudentFacade>();
            
            var allStudents = studentFacade.GetAllStudents();

            var studentWithId2 = studentFacade.GetStudentById(2);
            
        }

        private static void TestAnswerFacade() {
            var answerFacade = container.Resolve<AnswerFacade>();
            
        }

        private static void TestQuestionFacade() {
            var questionFacade = container.Resolve<QuestionFacade>();
            
            
        }

        private static void TestStudentGroupFacade() {
            var studentGroupFacade = container.Resolve<StudentGroupFacade>();
            
            
        }

        private static void TestTeacherFacade() {
            var teacherFacade = container.Resolve<TeacherFacade>();
            
            
        }

        private static void TestPrefaceFacade() {
            var testPrefaceFacade = container.Resolve<TestPrefaceFacade>();
            
            
        }

        private static void TestThematicFielFacade() {
            var thematicFieldFacade = container.Resolve<ThematicFieldFacade>();
            
            
        }

        private static void PerformStartup() {
            container = new WindsorContainer();
            container.Install(new Installer());
        }
    }
}
