using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Queries {
    class ThematicFieldListQuery : AppQuery<ThematicFieldDTO> {
        public ThematicFieldListQuery(IUnitOfWorkProvider provider) : base(provider) {
        }

        protected override IQueryable<ThematicFieldDTO> GetQueryable() {
            IQueryable<ThematicField> query = Context.ThematicFields;

            return query.ProjectTo<ThematicFieldDTO>();
        }
    }
}
