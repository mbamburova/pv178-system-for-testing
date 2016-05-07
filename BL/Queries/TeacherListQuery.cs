using System.Linq;
using AutoMapper.QueryableExtensions;
using BL.DTOs;
using DAL.Entities;
using Riganti.Utils.Infrastructure.Core;

namespace BL.Queries {
    public class TeacherListQuery : AppQuery<TeacherDTO> {
        public TeacherListQuery(IUnitOfWorkProvider provider) : base(provider) {
        }

        protected override IQueryable<TeacherDTO> GetQueryable() {
            IQueryable<Teacher> query = Context.Teachers;

            return query.ProjectTo<TeacherDTO>();
        }
    }
}
