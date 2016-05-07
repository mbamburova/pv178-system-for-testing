using System.Linq;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Queries {
    public class TestPrefaceListQuery : AppQuery<TestPrefaceDTO> {
        public TestPrefaceListQuery(IUnitOfWorkProvider provider) : base(provider) {
        }

        protected override IQueryable<TestPrefaceDTO> GetQueryable() {
            IQueryable<TestPreface> query = Context.TestPrefaces;

            return query.ProjectTo<TestPrefaceDTO>();
        }
    }
}
