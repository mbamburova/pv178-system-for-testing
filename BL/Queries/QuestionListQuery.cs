using Riganti.Utils.Infrastructure.Core;
using System.Linq;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;

namespace BL.Queries {
    public class QuestionListQuery : AppQuery<QuestionDTO> {

        public StudentFilter Filter { get; set; }
        public QuestionListQuery(IUnitOfWorkProvider provider) : base(provider) {
            
        }

        protected override IQueryable<QuestionDTO> GetQueryable() {
            IQueryable<Question> query = Context.Questions;

            if (string.IsNullOrEmpty(Filter.QuestionText)) {
                query = Context.Questions.Where(s => s.Text == Filter.QuestionText);
            }

            if (Filter.AnswerId > 0) {
                query = Context.Questions.Where(s => s.Answers.Any(c => c.Id == Filter.AnswerId));
            }
            return query.ProjectTo<QuestionDTO>();
        }
    }
}
