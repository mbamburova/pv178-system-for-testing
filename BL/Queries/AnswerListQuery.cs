using Riganti.Utils.Infrastructure.Core;
using System.Linq;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;

namespace BL.Queries {
    public class AnswerListQuery : AppQuery<AnswerDTO> {

        public AnswerListQuery(IUnitOfWorkProvider provider) : base(provider) {

        }

        protected override IQueryable<AnswerDTO> GetQueryable() {
            IQueryable<Answer> query = Context.Answers;

            return query.ProjectTo<AnswerDTO>();
        }
    }
}
