using Riganti.Utils.Infrastructure.Core;
using System.Linq;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;

namespace BL.Queries {
    public class QuestionListQuery : AppQuery<QuestionDTO> {

        public QuestionListQuery(IUnitOfWorkProvider provider) : base(provider) {
            
        }

        protected override IQueryable<QuestionDTO> GetQueryable() {
            IQueryable<Question> query = Context.Questions;
            
            return query.ProjectTo<QuestionDTO>();
        }
    }
}
