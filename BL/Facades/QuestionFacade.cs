using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.DTOs;
using BL.Queries;
using BL.Repositories;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Facades {
    class QuestionFacade : AppFacadeBase {

        public QuestionRepository Repository { get; set; }
        public QuestionListQuery QuestionListQuery { get; set; }

        protected IQuery<QuestionDTO> CreateQuery() {
            var query = QuestionListQuery;
            return query;
        }

        public List<QuestionDTO> GetAllQuestions() {
            using (UnitOfWorkProvider.Create()) {
                return CreateQuery().Execute().ToList();
            }
        }

        public QuestionDTO GetQuestionById(int questionId) {
            using (UnitOfWorkProvider.Create()) {
                var order = Repository.GetById(questionId);
                return Mapper.Map<QuestionDTO>(order);
            }
        }

        public List<QuestionDTO> GetQuestionsByThematicField() {
            throw new NotImplementedException();
        }
    }

}
