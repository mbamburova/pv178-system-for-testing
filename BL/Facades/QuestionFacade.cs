using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BL.DTOs;
using BL.Queries;
using BL.Repositories;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Facades {
    public class QuestionFacade : AppFacadeBase {

        public QuestionRepository Repository { get; set; }
        public QuestionListQuery QuestionListQuery { get; set; }

        protected IQuery<QuestionDTO> CreateQuery(StudentFilter filter) {
            var query = QuestionListQuery;
            query.Filter = filter;
            return query;
        }

        public List<QuestionDTO> GetAllQuestions() {
            using (UnitOfWorkProvider.Create()) {
                return CreateQuery(new StudentFilter { }).Execute().ToList();
            }
        }

        public QuestionDTO GetQuestionById(int questionId) {
            using (UnitOfWorkProvider.Create()) {
                var question = Repository.GetById(questionId);
                return Mapper.Map<QuestionDTO>(question);
            }
        }

        public List<QuestionDTO> GetQuestionsByThematicField() {
            throw new NotImplementedException();
        }
    }
}
