using System.Linq;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Queries {
    public class ThematicFieldListQuery : AppQuery<ThematicFieldDTO> {

        public ThematicFieldFilter Filter { get; set; }

        public ThematicFieldListQuery(IUnitOfWorkProvider provider) : base(provider) {
        }

        protected override IQueryable<ThematicFieldDTO> GetQueryable() {
            IQueryable<ThematicField> query = Context.ThematicFields;

            if (Filter.QuestionId > 0) {
                query = Context.ThematicFields.Where(s => s.Questions.Any(c => c.Id == Filter.QuestionId));
            }

            return query.ProjectTo<ThematicFieldDTO>();
        }
    }
}
