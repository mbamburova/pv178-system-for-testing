using Riganti.Utils.Infrastructure.Core;
using System.Linq;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;

namespace BL.Queries {
    public class AnswerListQuery : AppQuery<AnswerDTO> {

        public StudentGroupFilter Filter { get; set; }
        public AnswerListQuery(IUnitOfWorkProvider provider) : base(provider) {

        }

        protected override IQueryable<AnswerDTO> GetQueryable() {
            IQueryable<Answer> query = Context.Answers;
                if (Filter.QuestionId > 0) {
                query = Context.Answers.Where(s => s.Question.Id == Filter.QuestionId);
            }
            return query.ProjectTo<AnswerDTO>();
        }
    }
}
