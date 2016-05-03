using System;
using System.Configuration.Install;
using System.Linq;
using BL;
using BL.DTOs;
using BL.Facades;
using Castle.Windsor;
using Installer = BL.Installer;


namespace PL {
    class Program {

        private static IWindsorContainer container;

        static void Main(string[] args) {

            PerformStartup();

            TestAnswerFacade();
        }

        private static void TestAnswerFacade() {
            var answerFacade = container.Resolve<AnswerFacade>();

            var allAnswers = answerFacade.GetAllAnswers();

            var answerWithId2 = answerFacade.GetAswerById(2);
        }

        private static void PerformStartup() {

            container = new WindsorContainer();
            container.Install(new Installer());
        }


    }

}
