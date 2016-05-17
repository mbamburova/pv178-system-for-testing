using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BL.DTOs;
using BL.Queries;
using BL.Repositories;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Facades {
    public class AnswerFacade : AppFacadeBase {

        public AnswerRepository Repository { get; set; }
        public AnswerListQuery AnswerListQuery { get; set; }


        protected IQuery<AnswerDTO> CreateQuery(QuestionFilter filter) {
            var query = AnswerListQuery;
            query.Filter = filter;
            return query;
        }

        public List<AnswerDTO> GetAllAnswers() {
            using (var uow = UnitOfWorkProvider.Create()) {
                return CreateQuery(new QuestionFilter {}).Execute().ToList();
            }
        }

        public AnswerDTO GetAswerById(int answerId) {
            using (var uow = UnitOfWorkProvider.Create()) {
                var appAnswer = Repository.GetById(answerId);
                return Mapper.Map<AnswerDTO>(appAnswer);
            }
        }

        public List<AnswerDTO> GetAnswersByQuestion(int questionId) {
            using (var uow = UnitOfWorkProvider.Create()) {
                return CreateQuery(new QuestionFilter() {  QuestionId = questionId}).Execute().ToList();
            }
        }

        public void DeleteAnswer(int answerId) {
            using (var uow = UnitOfWorkProvider.Create()) {
                Repository.Delete(answerId);
                uow.Commit();
            }
        }
    }
}
