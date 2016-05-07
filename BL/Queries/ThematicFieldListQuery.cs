using System.Linq;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Queries {
    public class ThematicFieldListQuery : AppQuery<ThematicFieldDTO> {
        public ThematicFieldListQuery(IUnitOfWorkProvider provider) : base(provider) {
        }

        protected override IQueryable<ThematicFieldDTO> GetQueryable() {
            IQueryable<ThematicField> query = Context.ThematicFields;

            return query.ProjectTo<ThematicFieldDTO>();
        }
    }
}
